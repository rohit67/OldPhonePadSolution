using OldPhonePadLibrary;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapPost("/decode", (DecodeRequest request) =>
{
    var output = OldPhonePadDecoder.Decode(request.Input);

    return Results.Ok(new DecodeResponse(output));
});

app.Run();

record DecodeRequest(string Input);

record DecodeResponse(string Output);