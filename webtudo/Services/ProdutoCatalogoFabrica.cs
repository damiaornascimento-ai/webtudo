using webtudo.Models;

namespace webtudo.Services
{
    internal static class ProdutoCatalogoFabrica
    {
        private static string Img(string texto) =>
            $"https://placehold.co/280x170/3d9ad4/0e3552?text={Uri.EscapeDataString(texto)}";

        internal static List<ProdutoItem> Criar()
        {
            return
            [
                // --- Celulares (ofertas reais de mercado, precos referencia BR) ---
                C(1, "iPhone 14 Pro Max 256GB", "Celulares", "Apple", 7499m, "7.499", 4.8, 320,
                    "img-produto-1", true, true, false,
                    "Tela Super Retina XDR de 6,7\", chip A16 Bionic e camera de 48 MP.",
                    "O iPhone 14 Pro Max traz tela Always-On, Dynamic Island, corpo em aco inoxidavel e resistencia IP68. " +
                    "Camera principal de 48 MP com modo Action para videos, gravacao em ProRes e bateria para o dia todo. " +
                    "Suporta 5G, Face ID, MagSafe e atualizacoes de iOS por varios anos. Ideal para criacao de conteudo e uso profissional."),

                C(2, "iPhone 17 Pro Max 256GB", "Celulares", "Apple", 10499m, "10.499", 4.9, 180,
                    "img-produto-2", true, true, true,
                    "Linha Pro Max com desempenho maximo, cameras avancadas e tela premium.",
                    "Smartphone topo de linha com processador de ultima geracao, sistema de cameras Pro para foto e video em 4K, " +
                    "tela OLED de alta taxa de atualizacao e construcao premium. Inclui recursos de inteligencia artificial on-device, " +
                    "conectividade 5G avancada, resistencia a agua e integracao com ecossistema Apple."),

                C(3, "Samsung Galaxy S25 Ultra 256GB", "Celulares", "Samsung", 8999m, "8.999", 4.7, 250,
                    Img("Galaxy S25 Ultra"),
                    true, false, true,
                    "Galaxy AI, S Pen integrada, camera de 200 MP e tela Dynamic AMOLED 2X.",
                    "O Galaxy S25 Ultra possui tela de 6,9\" QHD+, processador Snapdragon 8 Elite, camera quadrupla com sensor de 200 MP " +
                    "e zoom optico de 5x. S Pen embutida para anotacoes, traducao em tempo real com Galaxy AI, bateria de 5000 mAh com carregamento rapido " +
                    "e resistencia IP68. Armazenamento UFS 4.0 e atualizacoes de seguranca prolongadas."),

                C(13, "iPhone 15 128GB", "Celulares", "Apple", 5899m, "5.899", 4.8, 410,
                    Img("iPhone 15"),
                    true, true, false,
                    "Chip A16 Bionic, camera de 48 MP e porta USB-C.",
                    "iPhone 15 com design em aluminio colorido, tela Super Retina XDR de 6,1\", camera principal de 48 MP com modo retrato aprimorado " +
                    "e gravacao Dolby Vision HDR. Porta USB-C, 5G, Face ID e compatibilidade com MagSafe. Excelente equilibrio entre preco e desempenho na linha Apple."),

                C(14, "Samsung Galaxy A55 5G 256GB", "Celulares", "Samsung", 2199m, "2.199", 4.5, 890,
                    Img("Galaxy A55"),
                    true, true, true,
                    "Tela Super AMOLED 120 Hz, IP67 e excelente custo-beneficio.",
                    "Smartphone intermediario com tela FHD+ de 6,6\" a 120 Hz, processador Exynos, camera tripla de ate 50 MP e selfie de 32 MP. " +
                    "Corpo em vidro e aluminio com classificacao IP67, bateria de 5000 mAh e carregamento de 25 W. Suporte a 5G e atualizacoes One UI."),

                C(15, "Xiaomi 14T Pro 512GB", "Celulares", "Xiaomi", 3999m, "3.999", 4.6, 520,
                    Img("Xiaomi 14T Pro"),
                    true, true, true,
                    "MediaTek Dimensity 9300+, camera Leica e carregamento de 120 W.",
                    "O Xiaomi 14T Pro traz tela CrystalRes AMOLED de 6,67\" 144 Hz, processador Dimensity 9300+, sistema de cameras Leica com sensor principal de 50 MP " +
                    "e gravacao em 8K. Carregamento HyperCharge de 120 W (bateria cheia em cerca de 20 minutos), Wi-Fi 7 e resistencia IP68."),

                C(16, "Motorola Edge 50 Ultra 512GB", "Celulares", "Motorola", 4299m, "4.299", 4.5, 310,
                    Img("Edge 50 Ultra"),
                    true, false, true,
                    "Camera de 50 MP com lente periscopio, tela pOLED 165 Hz e Snapdragon 7s Gen 2.",
                    "Destaque para camera tripla com lente periscopio de 50 MP (zoom 5x), tela pOLED de 6,7\" curva com 165 Hz e HDR10+, " +
                    "processador Snapdragon 7s Gen 2, bateria de 4500 mAh com carregamento TurboPower de 125 W e acabamento em couro vegano. Android puro com atualizacoes garantidas."),

                C(17, "Google Pixel 9 Pro 128GB", "Celulares", "Google", 6999m, "6.999", 4.7, 195,
                    Img("Pixel 9 Pro"),
                    true, true, true,
                    "Tensor G4, Android puro e melhor camera computacional do mercado.",
                    "Pixel 9 Pro com chip Google Tensor G4 otimizado para IA, tela Actua de 6,3\" LTPO a 120 Hz, cameras com zoom optico de 5x e " +
                    "recursos exclusivos como Magic Editor, Call Screen e sete anos de atualizacoes. Integracao profunda com Google Photos e Gemini."),

                // --- Placas de video ---
                C(18, "NVIDIA GeForce RTX 4070 Super 12GB", "Placas de Video", "NVIDIA", 2899m, "2.899", 4.8, 640,
                    Img("RTX 4070 Super"),
                    true, true, true,
                    "1440p ultra e ray tracing com DLSS 3.5, 12 GB GDDR6X.",
                    "A RTX 4070 Super oferece 7168 nucleos CUDA, 12 GB de memoria GDDR6X em barramento de 192 bits e consumo tipico de 220 W. " +
                    "Ideal para jogos em 1440p com ray tracing, criacao de conteudo e IA local. Suporta DLSS 3.5, AV1 encode/decode e Resizable BAR. " +
                    "Recomendada fonte de 650 W ou superior."),

                C(19, "NVIDIA GeForce RTX 4060 Ti 8GB", "Placas de Video", "NVIDIA", 2199m, "2.199", 4.6, 820,
                    Img("RTX 4060 Ti"),
                    true, true, false,
                    "1080p/1440p com eficiencia energetica e DLSS 3.",
                    "Placa de entrada na arquitetura Ada Lovelace com 4352 nucleos CUDA e 8 GB GDDR6. Excelente para jogos em 1080p e 1440p com DLSS, " +
                    "streaming com NVENC de 8a geracao e baixo consumo (cerca de 160 W). Compativel com PCIe 4.0 x8."),

                C(20, "AMD Radeon RX 7800 XT 16GB", "Placas de Video", "AMD", 3199m, "3.199", 4.7, 380,
                    Img("RX 7800 XT"),
                    true, false, true,
                    "16 GB GDDR6, excelente para 1440p e FSR 3.",
                    "A RX 7800 XT possui 3840 stream processors, 16 GB GDDR6 em interface de 256 bits e TDP de 263 W. " +
                    "Desempenho forte em 1440p com FSR 3 e ray tracing, suporte a DisplayPort 2.1 e AV1 decode. Alternativa competitiva a placas NVIDIA de faixa similar."),

                C(21, "NVIDIA GeForce RTX 4090 24GB", "Placas de Video", "NVIDIA", 12999m, "12.999", 4.9, 95,
                    Img("RTX 4090"),
                    false, true, false,
                    "Topo de linha para 4K, IA e workstations gamer.",
                    "A RTX 4090 e a GPU consumer mais poderosa: 16384 nucleos CUDA, 24 GB GDDR6X e TGP de 450 W. " +
                    "Roda jogos em 4K com ray tracing maximo, acelera treinamento de modelos de IA e edicao de video 8K. Requer gabinete amplo e fonte de 850 W+."),

                C(22, "AMD Radeon RX 7700 XT 12GB", "Placas de Video", "AMD", 2499m, "2.499", 4.6, 445,
                    Img("RX 7700 XT"),
                    true, true, true,
                    "12 GB GDDR6, foco em 1440p com otimo custo-beneficio.",
                    "RX 7700 XT com 3456 stream processors, 12 GB GDDR6 e interface de 192 bits. Posicionada entre 4060 Ti e 4070 Super em desempenho bruto, " +
                    "com suporte a FSR 3, AMD Fluid Motion Frames e tecnologias Anti-Lag+."),

                // --- Hardware ---
                C(23, "Kingston Fury Beast DDR5 32GB (2x16) 5600MHz", "Hardware", "Kingston", 749m, "749", 4.7, 1200,
                    Img("DDR5 32GB"),
                    true, true, false,
                    "Kit dual-channel DDR5 com perfil baixo e XMP 3.0.",
                    "Memoria DDR5 de 32 GB (2 modulos de 16 GB) a 5600 MT/s, latencia CL40, voltagem 1,25 V. Compativel com Intel XMP 3.0 e AMD EXPO. " +
                    "Dissipador de perfil baixo ideal para gabinetes compactos. Garantia vitalicia Kingston."),

                C(24, "SSD Samsung 990 PRO 2TB NVMe M.2", "Hardware", "Samsung", 999m, "999", 4.9, 2100,
                    Img("SSD 990 PRO"),
                    true, true, true,
                    "Leitura ate 7450 MB/s, PCIe 4.0 e controlador Samsung Pascal.",
                    "SSD NVMe M.2 2280 com interface PCIe 4.0 x4, leitura sequencial de ate 7450 MB/s e escrita de ate 6900 MB/s. " +
                    "Controlador Samsung Pascal, memoria V-NAND 3-bit e dissipador opcional. Ideal para SO, jogos e edicao de video 4K."),

                C(25, "Fonte Corsair RM850e 850W 80 Plus Gold", "Hardware", "Corsair", 699m, "699", 4.6, 560,
                    Img("Fonte 850W"),
                    true, false, false,
                    "850 W, modular, silenciosa e certificacao 80 Plus Gold.",
                    "Fonte ATX 3.0 de 850 W com eficiencia 80 Plus Gold, cabos totalmente modulares e ventoinha de 140 mm com modo zero RPM. " +
                    "Suporta GPUs de alta potencia com conector 12VHPWR nativo. Garantia de 7 anos Corsair."),

                C(26, "Processador AMD Ryzen 7 7800X3D", "Hardware", "AMD", 2499m, "2.499", 4.9, 890,
                    Img("Ryzen 7800X3D"),
                    true, true, true,
                    "8 nucleos, 3D V-Cache e referencia absoluta em jogos.",
                    "CPU AM5 com 8 nucleos / 16 threads, frequencia boost de ate 5,0 GHz e 96 MB de cache L3 com tecnologia 3D V-Cache. " +
                    "A melhor escolha para gaming puro em 2025/2026. TDP de 120 W, suporte a DDR5 e PCIe 5.0. Requer cooler adequado."),

                C(27, "Placa-mae ASUS TUF Gaming B650-PLUS WiFi", "Hardware", "ASUS", 1499m, "1.499", 4.5, 340,
                    Img("B650 TUF"),
                    true, false, true,
                    "Socket AM5, PCIe 5.0, Wi-Fi 6 e VRM robusto.",
                    "Placa-mae ATX para AMD Ryzen 7000/8000 com chipset B650, VRM de 12+2 fases, DDR5 ate 6400+ MHz (OC), " +
                    "slot M.2 PCIe 5.0, Wi-Fi 6 integrado, 2,5G Ethernet, USB 3.2 Gen 2 e construcao militar TUF. Ideal para builds gamer de medio-alto desempenho."),

                C(28, "Cooler CPU Cooler Master Hyper 212 Spectrum", "Hardware", "Cooler Master", 249m, "249", 4.4, 1500,
                    Img("Hyper 212"),
                    true, true, false,
                    "Cooler a ar com 4 heatpipes e iluminacao ARGB.",
                    "Cooler a ar universal com 4 heatpipes de contato direto, ventoinha de 120 mm PWM (650-1800 RPM) e iluminacao ARGB. " +
                    "Compativel com Intel LGA 1700/1200 e AMD AM5/AM4. Excelente relacao custo-beneficio para CPUs de ate 150 W TDP."),

                // --- Informatica ---
                C(29, "Notebook ASUS Vivobook 15 Intel i5 16GB 512GB SSD", "Informatica", "ASUS", 3499m, "3.499", 4.5, 720,
                    Img("Vivobook 15"),
                    true, true, true,
                    "Intel Core i5, 16 GB RAM, SSD 512 GB e tela Full HD 15,6\".",
                    "Notebook para estudo e trabalho com processador Intel Core i5 de 12a geracao, 16 GB DDR4, SSD NVMe de 512 GB, tela IPS Full HD de 15,6\", " +
                    "Wi-Fi 6, webcam HD com obturador de privacidade e Windows 11. Peso aproximado de 1,7 kg."),

                C(30, "Monitor LG UltraGear 27\" 27GP850-B 165Hz QHD", "Informatica", "LG", 1899m, "1.899", 4.7, 430,
                    Img("Monitor 27 QHD"),
                    true, false, true,
                    "27\" QHD, 165 Hz, 1 ms GTG e compativel com G-Sync.",
                    "Monitor gamer IPS de 27\" com resolucao 2560x1440, taxa de 165 Hz (OC 180 Hz), tempo de resposta de 1 ms GTG, " +
                    "suporte a AMD FreeSync Premium e NVIDIA G-Sync Compatible, HDR10 e ergonomia completa (altura, inclinacao, rotacao)."),

                C(31, "SSD Kingston NV3 1TB NVMe PCIe 4.0", "Informatica", "Kingston", 399m, "399", 4.6, 1800,
                    Img("SSD NV3 1TB"),
                    true, true, true,
                    "Leitura ate 6000 MB/s, ideal para upgrade rapido.",
                    "SSD M.2 2280 PCIe 4.0 x4 NVMe com capacidade de 1 TB, leitura de ate 6000 MB/s e escrita de ate 5000 MB/s. " +
                    "Solucao acessivel para expandir armazenamento em notebooks e desktops sem sacrificar velocidade."),

                C(32, "Teclado Logitech MX Keys S Wireless", "Informatica", "Logitech", 549m, "549", 4.8, 670,
                    Img("MX Keys S"),
                    true, true, false,
                    "Teclas baixas, retroiluminacao inteligente e multi-dispositivo.",
                    "Teclado wireless premium com teclas concavas, retroiluminacao que se adapta a luz ambiente, conexao via Bluetooth ou receptor USB Logi Bolt, " +
                    "ate 3 dispositivos com Easy-Switch e bateria recarregavel USB-C com autonomia de ate 10 dias com luz ligada."),

                // --- Ofertas (destaques promocionais) ---
                C(33, "Kit Upgrade Gamer: Ryzen 5 + B550 + 16GB DDR4", "Ofertas", "AMD", 1899m, "1.899", 4.5, 280,
                    Img("Kit Ryzen 5"),
                    true, true, true,
                    "Oferta combo: processador, placa-mae e memoria para montar PC.",
                    "Kit promocional com AMD Ryzen 5 5600 (6c/12t), placa-mae B550 compativel e memoria DDR4 16 GB 3200 MHz. " +
                    "Economia de cerca de 15% em relacao a compra separada. Ideal para upgrade de plataforma AM4 com excelente custo-beneficio em jogos."),

                C(34, "Combo SSD 1TB + Pasta Termica Artic MX-4", "Ofertas", "Kingston", 449m, "449", 4.4, 510,
                    Img("Combo SSD"),
                    true, true, true,
                    "Oferta manutencao PC: armazenamento rapido + thermal paste premium.",
                    "Pacote com SSD Kingston NV3 1TB NVMe e pasta termica Arctic MX-4 (8 g) para reaplicacao em CPU/GPU. " +
                    "Perfeito para revitalizar notebook ou desktop antigo com boot mais rapido e temperaturas menores."),

                // --- Legado consoles / acessorios mantidos ---
                C(4, "Sony PlayStation 5 Slim Digital 825GB", "Ofertas", "Sony", 3499m, "3.499", 4.6, 410,
                    "img-produto-4", false, true, false,
                    "Console next-gen Sony com SSD ultrarrapido e DualSense.",
                    "PlayStation 5 Slim versao Digital com SSD de 825 GB, suporte a ray tracing, audio 3D Tempest e controle DualSense com feedback haptico. " +
                    "Compativel com jogos PS5 e PS4, streaming de midia e biblioteca da PlayStation Store."),

                C(5, "PlayStation 4 1TB Edicao Limitada Days of Play", "Ofertas", "Sony", 3599m, "3.599", 4.5, 95,
                    "img-produto-5", true, false, false,
                    "Edicao colecionavel cinza com 1 TB de armazenamento.",
                    "Console PS4 Fat de 1 TB na edicao limitada Days of Play na cor cinza. Inclui biblioteca compativel com milhares de titulos PS4, " +
                    "PlayStation Plus (assinatura separada) e controle DualShock 4. Item colecionavel com disponibilidade reduzida."),

                C(6, "Console PlayStation 5 Standard 825GB", "Ofertas", "Sony", 4499m, "4.499", 4.9, 520,
                    "https://encrypted-tbn0.gstatic.com/shopping?q=tbn:ANd9GcQD7IcB7WVDclIxTqmCYDKbn1mtAr_2D7J5aWMIRsFIdyXxLJapw7hawHj0SgLK_fd2ZcTjorZUxtThiX4fBYy9PRq1QdzEzmaXPh_7duINFij-G9YBm-yM_RI3qU5nJPANyfUa0Q&usqp=CAc",
                    true, true, true,
                    "Leitor de discos Ultra HD Blu-ray e mesmo desempenho da versao Slim.",
                    "PS5 com unidade de disco para jogos em midia fisica e Blu-ray 4K, SSD 825 GB, ray tracing e 4K ate 120 fps em jogos compatíveis. " +
                    "Inclui controle DualSense. Versao completa para quem prefere discos e revenda de jogos."),

                C(8, "Notebook Gamer ASUS TUF A15 RTX 4050", "Informatica", "ASUS", 5999m, "5.999", 4.4, 160,
                    Img("TUF A15"),
                    false, true, true,
                    "Ryzen 7, RTX 4050 6 GB, 16 GB RAM e tela 144 Hz.",
                    "Notebook gamer com AMD Ryzen 7, placa NVIDIA RTX 4050 Laptop 6 GB, 16 GB DDR5 (expansivel), SSD 512 GB, tela 15,6\" IPS 144 Hz, " +
                    "teclado RGB e sistema de resfriamento TUF. Ideal para jogos em Full HD/High e estudo de programacao."),

                C(11, "Mouse Gamer Logitech G502 X Lightspeed", "Informatica", "Logitech", 649m, "649", 4.7, 980,
                    Img("G502 X"),
                    true, true, false,
                    "Mouse sem fio com sensor HERO 25K e 11 botoes programaveis.",
                    "G502 X Lightspeed com sensor HERO 25K (25.600 DPI), conexao wireless LIGHTSPEED com latencia de 1 ms, 11 botoes programaveis, " +
                    "bateria de ate 140 horas e peso ajustavel. Switches LIGHTFORCE hibridos para clique rapido e duravel.")
            ];
        }

        private static ProdutoItem C(
            int id, string nome, string categoria, string marca, decimal preco, string precoCompra,
            double avaliacao, int vendas, string imagem, bool freteGratis, bool entregaRapida, bool produtoNovo,
            string resumo, string completa)
        {
            return new ProdutoItem
            {
                Id = id,
                Nome = nome,
                Categoria = categoria,
                Marca = marca,
                Preco = preco,
                PrecoCompra = precoCompra,
                Avaliacao = avaliacao,
                Vendas = vendas,
                ImagemUrl = imagem,
                FreteGratis = freteGratis,
                EntregaRapida = entregaRapida,
                ProdutoNovo = produtoNovo,
                EmEstoque = true,
                DescricaoResumo = resumo,
                DescricaoCompleta = completa
            };
        }
    }
}
