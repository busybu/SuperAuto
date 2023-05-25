public class ProcessArgs
{
    private static ProcessArgs empty = new ProcessArgs();
    public static ProcessArgs Empty => empty;
}

public class PecaArgs : ProcessArgs
{
}

public class JogadorArgs : ProcessArgs
{
}

public class BatalhaArgs : ProcessArgs
{
}

public class MercadoArgs : ProcessArgs
{
}

public class ArgsInicial : ProcessArgs
{
}
