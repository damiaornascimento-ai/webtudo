import re
from pathlib import Path

index = Path(__file__).resolve().parents[1] / "Pages" / "Index.cshtml"
content = index.read_text(encoding="utf-8")
cards = re.findall(
    r'<div class="produto-card">(.*?)</div>\s*(?=\n\s*<div class="produto-card">|\n\s*</div>\s*</div>)',
    content,
    re.S,
)
out = Path(__file__).resolve().parents[1] / "Services" / "ProdutoImagensLegacy.cs"
lines = [
    "namespace webtudo.Services",
    "{",
    "    public static class ProdutoImagensLegacy",
    "    {",
    "        private static readonly Dictionary<int, string> Imagens = new()",
    "        {",
]
for i, card in enumerate(cards, 1):
    m = re.search(r'<img src="([^"]+)"', card)
    if m:
        src = m.group(1).replace("\\", "\\\\").replace('"', '\\"')
        lines.append(f'            [{i}] = "{src}",')
lines.extend(
    [
        "        };",
        "",
        "        public static string? Obter(int id) => Imagens.TryGetValue(id, out var url) ? url : null;",
        "    }",
        "}",
    ]
out.write_text("\n".join(lines), encoding="utf-8")
print(f"Wrote {out} with {len(cards)} images")
