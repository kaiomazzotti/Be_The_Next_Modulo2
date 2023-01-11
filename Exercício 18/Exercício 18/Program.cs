//    Crie uma classe Camera que deve ter como propriedades resolucaoMaxima e fotosTiradas e um método tiraFoto
//    que apenas aumenta o número de fotos tiradas. Crie uma classe Celular que tenha como propriedades 
//    espacoDisponivel (em número de fotos), cameraFrontal e cameraTraseira. Tanto a cameraFrontal como a
//    cameraTraseira devem ser classes que herdam de Camera e tem como propriedades adicionais a resolucaoAtual 
//    (não pode ser superior à resolucaoMaxima). Ambas apenas podem tirar fotos se houver espaço disponível
//    no celular e a cameraFrontal deve ter resolucaoMaxima menor que a cameraTraseira.

using Exercício_18;

CameraFrontal f1 = new CameraFrontal(1300,700);
CameraTraseira t1 = new CameraTraseira(1300,1250);
Celular c1 = new Celular(4, f1, t1);
c1.TirandoFotosCelularT();
c1.TirandoFotosCelularT();
c1.TirandoFotosCelularF();
c1.TirandoFotosCelularT();
c1.TirandoFotosCelularT();
c1.TirandoFotosCelularF();

Console.WriteLine("Fotos tiradas com a camera frontal: " + c1.CamFrontal.FotosTiradas);
Console.WriteLine("Fotos tiradas com a camera traseira: " + c1.CamTraseira.FotosTiradas);