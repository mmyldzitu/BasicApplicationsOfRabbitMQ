// See https://aka.ms/new-console-template for more information

//Eski Sürümlerde nasıldı?
// class Program{

//     static void Main(string[] args){
//         if(args.Length>0){
//             foreach(var item in args){
//             Console.WriteLine("İtem:"+item);

//             }


//         }
//         else{
//             Console.WriteLine("Hello World");
//         }


//     }


// }
//Yeni Sürümlerde Nasıl?
if(args.Length>0){

    foreach(var item in args){
        Console.WriteLine("İtem:"+item);
    }

}
else{
    Console.WriteLine("Hello World");
}