public class NormalPost{

    public virtual string CreatePost(string post,DataBase db){
        return db.AddNormalPost(post);
    }

}


public class TagPost:NormalPost{
    public override string CreatePost(string post,DataBase db){
        return db.AddTagPost(post);
    }
}



public class MentionPost:NormalPost{
    public override string CreatePost(string post,DataBase db){
        return db.AddMentionPost(post);
    }
}