
/// <summary>
/// /////////////////// 
/// Before ISp
/// -divided the fat interFace into many interfaces each one have a necessary for it 
/// -Avoid Fat InterFace " Fat interFace=> means the class that almost have all methods in software " 

/// </summary>

public interface Cloud{

    public String File{set;get;}
    public String CDNA{set;get;}


    public void SetFile(String file);
    


    public string GetFile();



    public String getCDNAddress(); 

    public void CreateServer();


    public void ListServers();
}

class Amazon : Cloud
{
    public string File { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string CDNA { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void CreateServer()
    {
        throw new NotImplementedException();
    }

    public string getCDNAddress()
    {
        throw new NotImplementedException();
    }

    public string GetFile()
    {
        throw new NotImplementedException();
    }

    public void ListServers()
    {
        throw new NotImplementedException();
    }

    public void SetFile(string file)
    {
        throw new NotImplementedException();
    }
}


class dropbox : Cloud
{
    string Cloud.File { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    string Cloud.CDNA { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    void Cloud.CreateServer()
    {
        throw new NotImplementedException();
    }

    string Cloud.getCDNAddress()
    {
        throw new NotImplementedException();
    }

    string Cloud.GetFile()
    {
        throw new NotImplementedException();
    }

    void Cloud.ListServers()
    {
        throw new NotImplementedException();
    }

    void Cloud.SetFile(string file)
    {
        throw new NotImplementedException();
    }
}