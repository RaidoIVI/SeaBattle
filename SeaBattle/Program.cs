

var aa = new Ship (1,1,4,ShipLocate.Horizontal) ;
var aaa = new Ship (1,1,4,ShipLocate.Vertical ) ;
//Console.WriteLine(aa.Value);
//aa.Draft();
var a = new Board(10, 10);
a.ShipAdd (aa);
a.Draft();





Console.ReadKey();
