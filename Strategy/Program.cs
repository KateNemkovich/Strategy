using Strategy;

//new Kate().Rest();
//new Rome().Rest();
var rests = new List<IRest>
{
    new Kate(),
    new Rome()
};
foreach( var rest in rests)
{
    rest.Rest();
}
    