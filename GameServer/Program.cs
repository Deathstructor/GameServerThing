using System.Security.AccessControl;
using System.Numerics;
using System.Text.Json;

WebApplication app = WebApplication.Create();

Position paulCords = new(100, 10);
Position samuelCords = new(10, 10);
Position dummy = new();

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

// Previous test
// (JsonContent j) =>
// {
//     Position p = JsonSerializer.Deserialize<Position>(j.ToString());
//     paulCords = p;

//     return "i got here";
// }

app.MapPost("/Paul/Set/", SetPaul);
app.MapPost("/Samuel/Set/", SetSamuel);

void SetSamuel(Position p)
{
    samuelCords = p;
    dummy = p;
}
void SetPaul(Position p)
{
    paulCords = p;
}

app.Run();

dynamic Answer()
{
    // return "Up and running! :D";
    return dummy;
}