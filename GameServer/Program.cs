WebApplication app = WebApplication.Create();

Position paulCords = new(100, 10);
Position samuelCords = new(10, 10);

app.Urls.Add("http://localhost:3000");
app.Urls.Add("http://*:3000");

app.MapGet("/", Answer);
app.MapGet("/Paul/Get/", () =>
{
    return paulCords;
});
app.MapGet("/Samuel/Get/", () =>
{
    return samuelCords;
});

app.MapPost("/Paul/Set/", SetPaul);
app.MapPost("/Samuel/Set/", SetSamuel);

void SetSamuel(Position p)
{
    samuelCords = p;
}
void SetPaul(Position p)
{
    paulCords = p;
}

app.Run();

string Answer()
{
    return "Up and running! :D";
}