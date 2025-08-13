# Models
Es werden Models f�r die LoadPorts und die einzelnen Slots benutzt. Die LoadPorts stellen eine Liste aus 25 Slots dar und die Slots zeigen durch den bool "__is__Filled" an, ob ein Wafer in dem Slot liegt oder nicht.

# ViewModels
Das MainViewModel ist daf�r zust�ndig die Load Port 1, 2 und den Roboter Arm zu initiieren. Beim Start des Programms wird LP1 mit Wafern gef�llt und LP2 leer gelassen. Beim dr�cken auf den Start Button wird der Arm bewegt und alle Wafer werden nacheinander von LP1 zu LP2 gebracht.
Das RobotViewModel enth�lt getter und setter Methoden daf�r, ob der Arm sich bewegt, er einen Wafer h�lt und f�r den aktuellen Rotationswinkel. In der Methode MoveRobotAsync k�nnen Start- und Endwinkel angegeben werden und der Arm bewegt sich zwischen diesen Winkeln.
Im LoadPortViewModel wird im Konstruktor lediglich die Liste an Slots initialisiert, die 25 Eintr�ge enth�lt.
In TransferCommand wird f�r die Buttons benutzt, um zu steuern was passiert wenn auf Start und Pause geklickt wird.

# Views
MainWindow teilt das Hauptfenster in ein Grid ein, in dem LP 1 in der linken Spalte liegt, der Roboter Arm in der mittleren und LP2 in der rechten. Die Buttons liegen hierbei unten mittig.
Die LoadPorts und der Roboterarm haben hierbei ihre eigenen beiden Views, jeweils in LoadPortControl und RobotArmControl. LoadPortControl.xaml ordnet die Liste vertikal an. In RobotArmControl wird zus�tzlich die Rotation des Armes beachtet.
WaferColorConverter ist daf�r da sowohl die Slots, als auch den Roboter Arm entsprechend einzuf�rben, wenn ein Wafer vorhanden ist. Enth�lt das jeweilige Element ein Wafer wird es Blau eingef�rbt, sonst grau.