using Model;

//取得資料庫
using var db= new BlogContext();
Console.WriteLine($"目前資料庫的路徑是:{db.DbPath}");
Console.WriteLine("新增數筆資料");
//db.Add(new Blog {Url="https://www.uuu.com.tw/"});
//db.Add(new Blog {Url="https://www.tibame.com/"});
//db.Add(new Blog {Url="https://hahow.in/"});

Console.WriteLine("新增Post資料");
var blog = db.Blogs!.OrderBy(b=> b.BlogId).Last();
blog.Url="https://www.cwb.gov.tw";
blog.Posts.Add(new Post{Title="urgent",Content="Typhoon is coming"});
blog.Posts.Add(new Post{Title="urgent",Content="Earthquake last night"});

db.SaveChanges();

Console.WriteLine("讀回資料");
var blogs = db.Blogs!.OrderBy(b => b.BlogId);
foreach (var b in blogs)
{
    Console.WriteLine($"{b.BlogId},{b.Url}");
    foreach (var p in b.Posts)
    {
        Console.WriteLine($"*{p.Title}/{p.Content}");
    }
    
}


