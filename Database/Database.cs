using System;
using System.Collections.Generic;
using shop.Models;

namespace shop.Database
{
    public static class Context
    {
        public static List<Category> Categories()
        {
            var result = new List<Category>();
            result.Add(new Category(new Guid("044dae05-30a1-4ced-8eee-6859fd43bace"), "Celulares e Telefonia", "telefonia"));
            result.Add(new Category(new Guid("795bc1b3-7455-436c-81b6-a06b4a037e30"), "Automotivo", "automotivo"));
            result.Add(new Category(new Guid("6b3448ab-1482-4d48-bfc7-a426e1583d21"), "Brinquedos e Bebês", "brinquedos"));
            result.Add(new Category(new Guid("d670402e-1a61-4de7-bdde-185501ab04e5"), "Informática", "informatica"));
            result.Add(new Category(new Guid("23084069-084c-424d-98e0-2ab29b145f10"), "TV e Áudio", "tv"));
            result.Add(new Category(new Guid("e269ecca-9372-43cb-bd96-69a36b628374"), "Eletrodomésticos", "eletrodomesticos"));
            result.Add(new Category(new Guid("22e50030-9dcc-4c0b-8737-f27d88234492"), "Móveis e Decoração", "decor"));
            result.Add(new Category(new Guid("bc643a4a-cb0e-474c-bda0-8c83626e8ec0"), "Moda e Beleza", "moda"));
            result.Add(new Category(new Guid("c165ee33-9d8e-4100-a97a-5865724973c8"), "Games", "games"));
            return result;
        }

        public static List<Product> Products()
        {
            var result = new List<Product>();
            #region Telefonia
            result.Add(new Product(
                new Guid("9a0dc81e-0b76-427f-8f9e-7502c2bd1005"),
                "Smartphone Motorola One 64GB",
                "smartphone-motorola-one-64gb",
                999,
                "Primeiro Android One do Brasil, o Motorola One chegou para inovar os seus dias, deixando tudo mais prático, rápido e moderno. Com ele, as mais recentes inovações tecnológicas do Google se ajustam automaticamente às suas necessidades, chegando até você com muito mais segurança.<br/><br/>Sua Tela Max Vision de 5,9’’ HD com proporção de 19:9 permite com seus filmes e séries sejam reproduzidos com nitidez e riqueza de detalhes, além de fazer com que você mergulhe numa experiência totalmente imersiva.<br/><br/>O Motorola One apresenta um sistema de câmera dupla avançado de 13MP + 2MP, que deixam suas fotos com aparência profissional, já que os seus recursos avançados facilitam uma melhor captura da imagem. Tudo isso, somados à um processador Octa-core, 4GB de memória RAM e 64GB de memória interna.<br/><br/>Ah! E a Bateria vem com 3000 mAh, garantindo um dia inteiro com uma única carga. Isso porque o carregador TurboPower oferece 6 horas de bateria em apenas 20 minutos de carregamento.<br/><br/>Motorola One: smartphone inteligente ao alcance de suas mãos!<br/><br/>",
                "Motorola",
                new string[]{
                    "smartphone-motorola-one-64gb",
                    "smartphone-motorola-one-64gb-002",
                    "smartphone-motorola-one-64gb-003",
                    "smartphone-motorola-one-64gb-004",
                    "smartphone-motorola-one-64gb-005",
                    "smartphone-motorola-one-64gb-006",
                    "smartphone-motorola-one-64gb-007",
                    "smartphone-motorola-one-64gb-008",
                },
                new Category(new Guid("044dae05-30a1-4ced-8eee-6859fd43bace"), "Celulares e Telefonia", "telefonia")
            ));
            // 58b3f5b6-55e8-4aa4-a352-a2e061b8aa6d
            // 0f8e8418-f3a3-4329-91c6-4548dc6af16b
            // 1c0487fd-1e33-47ec-9541-f8de43d8abfe
            // f58448de-bb53-48fa-8347-70bad73f1ec4
            // dd5a0bf0-d2f1-4b13-a50e-bb4946862cab
            // e6dd2d93-84a9-43f6-9d35-79054a8368c4
            // 1297eef5-33a5-41e9-9c8a-2344cb317ab0
            // f39dffaa-33b3-4dea-ac15-dd22f344461c
            // 288b95d5-a4c5-4994-9b3a-d97fa271c738
            // c58c8d8e-2c1f-4a9c-b505-92351e61e92a
            // 8a79b50f-af90-4cac-9071-7f04406e7093
            // 58ad1e07-159f-4325-a0c2-bd531728407b
            // 9ea23a9d-7713-4f46-81f3-163dc5ebe7d5
            // b83a0e57-018f-434b-afb1-2affd62fc764

            #endregion
            return result;
        }
    }
}