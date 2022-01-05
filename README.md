# Desarma a bomba

Esta aplicação tem o objetivo de desarmadilhar uma bomba que tem diversos cabos com cores diferentes para cortar.


O utilizador pode escolher entre 6 cores que são:
1. Branco
2. Preto
3. Vermelho
4. Laranja
5. Verde
6. Roxo
---
Para desarmadilhar a bomba há regras que se têm que cumprir para a bomba não explodir
- Depois de se cortar um fio branco não se podem cortar os fios brancos ou pretos;
- Depois de se cortar um fio preto não se podem cortar os fios brancos, verde ou laranja;
- Depois de se cortar um fio vermelho tem que se cortar um fio verde;
- Depois de se cortar um fio laranja tem que se cortar um fio vermelho ou preto;
- Depois de se cortar um fio verde tem que se cortar um fio laranja ou branco;
- Depois de se cortar um fio roxo não se podem cortar os fios brancos, roxo, laranja ou verde;
---
Esta aplicação foi desenvolvida em .net core (C#). Com recurso ao IDE JetBrains Rider

Nesta solução existe também uma vertende de testes que foram desenvolvidos em NUnit, que têm uma coverage total de 69%.


### Solução desenvolvida por:
Ricardo Alexandre de Jesus Faia
