namespace DesativarBombaNS {
    class DesativarBomba
    {
        public static Boolean continuarEscolha = true; //Variavel para se saber se o utilizador pode continuar a escolher fios
        
        public static String verificacaoBranco(String corEscolhida) {
            if (corEscolhida.Equals("branco") || corEscolhida.Equals("preto")) {
                continuarEscolha = false;
                return "A bomba explodiu!";
            } else {
                return "A bomba continua activa! Corta outro fio.";
            }
        }

        public static String verificacaoVermelho(String corEscolhida) {
            if (corEscolhida.Equals("verde")) {
                continuarEscolha = false;
                return "Muito bem! Bomba desactivada. Ufa...";
            } else {
                continuarEscolha = false;
                return "A bomba explodiu!";
            }
        }

        public static String verificacaoPreto(String corEscolhida) {
            if (corEscolhida.Equals("branco") || corEscolhida.Equals("verde") || corEscolhida.Equals("laranja")) {
                continuarEscolha = false;
                return "A bomba explodiu!";
            } else {
                return "A bomba continua activa! Corta outro fio.";
            }
        }

        public static String verificacaoLaranja(String corEscolhida) {
            if (corEscolhida.Equals("preto") || corEscolhida.Equals("vermelho")) {
                continuarEscolha = false;
                return "Muito bem! Bomba desactivada. Ufa...";
            } else {
                continuarEscolha = false;
                return "A bomba explodiu!";
            }
        }

        public static String verificacaoVerde(String corEscolhida) {
            if (corEscolhida.Equals("laranja") || corEscolhida.Equals("branco")) {
                continuarEscolha = false;
                return "Muito bem! Bomba desactivada. Ufa...";
            } else {
                continuarEscolha = false;
                return "A bomba explodiu!";
            }
        }

        public static String verificacaoRoxo(String corEscolhida) {
            if (corEscolhida.Equals("preto")) {
                return "A bomba continua activa! Corta outro fio.";
            } else {
                continuarEscolha = false;
                return "A bomba explodiu!";
            }
        }

        public static Boolean verificacaoCorValida(String cor) {
            if (!cor.Equals("branco") && !cor.Equals("vermelho") && !cor.Equals("preto") &&
                !cor.Equals("laranja") && !cor.Equals("verde") && !cor.Equals("roxo")) {
                Console.WriteLine("Cor escolhida não existe, tenta novamente!");
                return false;
            } else {
                return true;
            }
        }
        
        public static void Main() {
            String corAnterior = ""; //Para verificação do corte que o utilizador pertende fazer

            do {
                Console.WriteLine("Escolha a cor do fio a cortar:");
                String corEscolhida = Console.ReadLine().ToLower(); //Escolha da cor que o utilizador pretende cortar

                if (verificacaoCorValida(corEscolhida)) {
                    switch (corAnterior) {
                        case "branco":
                            Console.WriteLine(verificacaoBranco(corEscolhida));
                            break;
                        case "vermelho":
                            Console.WriteLine(verificacaoVermelho(corEscolhida));
                            break;
                        case "preto":
                            Console.WriteLine(verificacaoPreto(corEscolhida));
                            break;
                        case "laranja":
                            Console.WriteLine(verificacaoLaranja(corEscolhida));
                            break;
                        case "verde":
                            Console.WriteLine(verificacaoVerde(corEscolhida));
                            break;
                        case "roxo":
                            Console.WriteLine(verificacaoRoxo(corEscolhida));
                            break;
                        default:
                            Console.WriteLine("A bomba continua activa! Corta outro fio.");
                            break;
                    }

                    corAnterior = corEscolhida;
                }
                
            } while (continuarEscolha);
        }
    }
}