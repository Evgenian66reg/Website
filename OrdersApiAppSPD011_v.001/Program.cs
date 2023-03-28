using OrdersApiAppSPD011.Model.Entity;
using OrdersApiAppSPD011.Service.ClientService;
using OrdersApiAppSPD011.Service.OrderService;
using OrdersApiAppSPD011.Service.ProductService;
using OrdersApiAppSPD011.Service.SOPService;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IDaoClient, DbDaoClient>();
builder.Services.AddTransient<IDaoOrder, DbDaoOrder>();
builder.Services.AddTransient<IDaoProduct, DbDaoProduct>();
builder.Services.AddTransient<IDaoSOP, DbDaoSOP>();

var app = builder.Build();

app.MapGet("/", () => new { Time = DateTime.Now.ToString(), Message = "Server is running. "});

app.MapGet("/ping", () => new {Time = DateTime.Now, Message = "pong"});


// обработчики тестирования бизнес-логики для работы с клиентом
app.MapGet("/client/all", async (IDaoClient daoClient) =>
{
    return await daoClient.GetAllAsync();
});

app.MapPost("/client/add", async (Client client, IDaoClient daoClient) =>
{
    return await daoClient.AddAsync(client);
});

// обработчики тестирования бизнес-логики для работы с заказом
app.MapGet("/order/all", async (IDaoOrder daoOrder) =>
{
    return await daoOrder.GetAllAsync();
});

app.MapPost("/order/add", async (Order order, IDaoOrder daoOrder) =>
{
    return await daoOrder.AddAsync(order);
});

// обработчики тестирования бизнес-логики для работы с товаром
app.MapGet("/product/all", async (IDaoProduct daoProduct) =>
{
    return await daoProduct.GetAllAsync();
});

app.MapPost("/product/add", async (Product product, IDaoProduct daoProduct) =>
{
    return await daoProduct.AddAsync(product);
});


// обработчики тестирования бизнес-логики для работы с расшивкой заказ-товар
app.MapGet("/sop/all", async (IDaoSOP daoSOP) =>
{
    return await daoSOP.GetAllAsync();
});

app.MapPost("/sop/add", async (StitchingOrderProduct sop, IDaoSOP daoSOP) =>
{
    return await daoSOP.AddAsync(sop);
});




app.Run();
