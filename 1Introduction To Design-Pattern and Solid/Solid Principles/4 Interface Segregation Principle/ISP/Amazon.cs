public  class Amazon2 : CloudStorage, CDNA, CloudHosting
{
    string CloudStorage.FileName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    string CDNA.cdnaddress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    void CloudHosting.CreateHostingServer()
    {
        throw new NotImplementedException();
    }

    int CDNA.GetCSNAddress()
    {
        throw new NotImplementedException();
    }

    string CloudStorage.GetFile()
    {
        throw new NotImplementedException();
    }

    void CloudHosting.ListHostingServers()
    {
        throw new NotImplementedException();
    }

    void CloudStorage.setName()
    {
        throw new NotImplementedException();
    }
}