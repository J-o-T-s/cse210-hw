using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>()
        {
            new Video("Why I am starting my own Game Studio", "Mincey Studios", 622.2, 
            new List<Comment>()
            {
                new Comment("white Fairy", "Wow, this is incredible <3"),
                new Comment("Dev_Cartle", "Where's the form, I wanna join your team bro!"),
                new Comment("SillyCoder", "Pretty cool."),
                new Comment("Ha Ter", "Is this what bro is doing in the big 2025?"),
                new Comment("pinngShi", "I am interested, Where can I get the form?"),
            }),
            new Video("Making Video Games Pt. 1", "Mincey Studios", 1039.8,
            new List<Comment>()
            {
                new Comment("Dev_Cartle", "Where's the form, I wanna join your team bro!"),
                new Comment("SillyCoder", "Pretty cool."),
                new Comment("Queble", "Keep going bro, I know you're gonna make it!"),
                new Comment("white Fairy", "I knew this guy is cool! I subscribed 💐💗"),
                new Comment("sick_and_Tired", "hi buddy, u okay with a collab?"),
                new Comment("pink $herry", "Yes, this is tthe kind of dev studio I love!"),
            }),
            new Video("Why does our Brain Picture Game Ideas in a Fancy way than IRL", "Mincey Studios", 228.7,
            new List<Comment>()
            {
                new Comment("Klaus Jackson", "Hmm, this must be it!"),
                new Comment("SillyCoder", "silllyy!!"),
                new Comment("pink $herry", "I kinda like the point where he said, our brains are both enemies and friends in developement. Kinda reminds me of Eren Jaeger, from AOT!"),
            }),
            new Video("Grids and Tables With Numbers - Devlog 1| Bingo!", "Mincey Studios", 598.2,
            new List<Comment>()
            {
                new Comment("SillyCoder", "release it rn!!!! <3"),
                new Comment("Cool Sensei", "Mincey Studios is cooking smth fr!"),
                new Comment("sick_and_Tired", "I love Mincey Studios"),
                new Comment("white Fairy", "Can I get a like Mincey Studios :)"),
                new Comment("ModernUser", "this is a nice game Idea.Fun, simple and easy to grasp"),
                new Comment("Dev_Cartle", "this is a cool game idea!"),
                new Comment("Queble", "Cool vid bro, keep it up!"),
                new Comment("pink $herry", "Fr, this Studio is da beSSTT!"),
                new Comment("AyoooLi", "Where's the form, I want to be a part of this studio fr!"),
                new Comment("Ol Palco", "The cool hover effects on the grid looks coool"),
                new Comment("Sayye Itt", "The font is peak"),
            })
        };
        
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}