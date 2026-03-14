dialog text é um prefab feito para fazer aqueles dialogos de visual novel.

tutorial

1- adicione a cena e certifique que tenha apenas 1
2- nos eventos do player coloque o objeto do dialogtext nos eventos de interact e de skip e selecione as respectivas funções
após isso o dialogtext ja está pronto para ser usado

no script do player ele ja encontra e pega o script do dialog text no start do jogo

como na unity precisa de uma função Ienumerator para esperar outras funções terminarem todo os dialogos devem rodar numa unica função ienumerator

tome o exemplo

IEnumerator dialog1test()
    {
        yield return StartCoroutine(dialog_script.ds("neymar", "eu sou neymar. Eu jogo bola. interressanteme mente interesasnte mainte"));
        yield return StartCoroutine(dialog_script.d("neymar", "eu sou neymar. Eu jogo bola. inter dawa dsressanteme mensa dwa wadawdaw d awd awd awd as dsdaw awdasd wad awd wad awd w daw edwadwad ae3trf ws4te interesasnte mainte"));
        yield return StartCoroutine(dialog_script.d("neymar", "eu sou neymar. Eu jogo bola. inter dawa dsressanteme mensa dwa wadawdaw d awd awd awd as dsdaw awdasd wad awd wad awd w daw edwadwad ae3trf ws4te interesasnte mainte"));
        yield return StartCoroutine(dialog_script.d("neymar", "eu sou neymar. Eu jogo bola. inter dawa dsressanteme mensa dwa wadawdaw d awd awd awd as dsdaw awdasd wad awd wad awd w daw edwadwad ae3trf ws4te interesasnte mainte"));
        yield return StartCoroutine(dialog_script.d("neymar", "eu sou neymar. Eu jogo bola. inter dawa dsressanteme mensa dwa wadawdaw d awd awd awd as dsdaw awdasd wad awd wad awd w daw edwadwad ae3trf ws4te interesasnte mainte"));
        yield return StartCoroutine(dialog_script.df("neymaads war", "eu sawa dsressantaw edwadwad ae3trf ws4te interesasnte mainte"));
    }

e quando precisar chamar esse dialogo apenas use StartCoroutine(dialog1test());

note que há 3 funções no script
ds (dialog start) recebe 3 argumentos, o primeiro é o nome de quem está falando, o segundo oque está falando e o terceiro é se isso é um dialogo unico onde só inicia ou um que fecha quando terminar(normalmente é false, caso queira fechar use true). usado quando se inicia o dialog, no primeiro dialogo. deixa o dialog visivel
d recebe 2 argumentos, o primeiro para o nome e o segundo para o texo. usado para continuar o dialog, ele n fecha nem abre a caixa de dialog apenas continua
df (dialog fechar) recebe 2 argumentos igual os outros. Usado para finalizar o dialog, tirando a visibilidade do dialog text
