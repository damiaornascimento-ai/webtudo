$indexPath = Join-Path $PSScriptRoot "..\Pages\Index.cshtml"
$outPath = Join-Path $PSScriptRoot "..\Services\ProdutoImagensLegacy.cs"
$content = Get-Content $indexPath -Raw -Encoding UTF8
$pattern = '(?s)<div class="produto-card">(.*?)</div>\s*(?=\r?\n\s*<div class="produto-card">|\r?\n\s*</div>\s*</div>)'
$cards = [regex]::Matches($content, $pattern)
$sb = New-Object System.Text.StringBuilder
[void]$sb.AppendLine("namespace webtudo.Services")
[void]$sb.AppendLine("{")
[void]$sb.AppendLine("    public static class ProdutoImagensLegacy")
[void]$sb.AppendLine("    {")
[void]$sb.AppendLine("        private static readonly Dictionary<int, string> Imagens = new()")
[void]$sb.AppendLine("        {")
$i = 1
foreach ($card in $cards) {
    $imgMatch = [regex]::Match($card.Groups[1].Value, '<img src="([^"]+)"')
    if ($imgMatch.Success) {
        $src = $imgMatch.Groups[1].Value.Replace('\', '\\').Replace('"', '\"')
        [void]$sb.AppendLine("            [$i] = `"$src`",")
    }
    $i++
}
[void]$sb.AppendLine("        };")
[void]$sb.AppendLine("")
[void]$sb.AppendLine("        public static string? Obter(int id) => Imagens.TryGetValue(id, out var url) ? url : null;")
[void]$sb.AppendLine("    }")
[void]$sb.AppendLine("}")
$sb.ToString() | Set-Content $outPath -Encoding UTF8
Write-Host "Wrote $outPath with $($cards.Count) images"
