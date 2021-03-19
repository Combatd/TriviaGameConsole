
public class QuestionsLibraryTransferObject
{
    public int id { get; set; }
    public string question { get; set; }
    public object description { get; set; }
    public Answers answers { get; set; }
    public string multiple_correct_answers { get; set; }
    public Correct_Answers correct_answers { get; set; }
    public string correct_answer { get; set; }
    public object explanation { get; set; }
    public object tip { get; set; }
    public Tag[] tags { get; set; }
    public string category { get; set; }
    public string difficulty { get; set; }
}

public class Answers
{
    public string answer_a { get; set; }
    public string answer_b { get; set; }
    public string answer_c { get; set; }
    public string answer_d { get; set; }
    public object answer_e { get; set; }
    public object answer_f { get; set; }
}

public class Correct_Answers
{
    public string answer_a_correct { get; set; }
    public string answer_b_correct { get; set; }
    public string answer_c_correct { get; set; }
    public string answer_d_correct { get; set; }
    public string answer_e_correct { get; set; }
    public string answer_f_correct { get; set; }
}

public class Tag
{
    public string name { get; set; }
}
