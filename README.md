# Models
Es werden Models für die LoadPorts und die einzelnen Slots benutzt. Die LoadPorts stellen eine Liste aus 25 Slots dar und die Slots zeigen durch den bool "__is__Filled" an, ob ein Wafer in dem Slot liegt oder nicht.

# ViewModels
Das MainViewModel ist dafür zuständig die Load Port 1, 2 und den Roboter Arm zu initiieren. Beim Start des Programms wird LP1 mit Wafern gefüllt und LP2 leer gelassen. Beim drücken auf den Start Button wird der Arm bewegt und alle Wafer werden nacheinander von LP1 zu LP2 gebracht.
Das RobotViewModel enthält getter und setter Methoden dafür, ob der Arm sich bewegt, er einen Wafer hält und für den aktuellen Rotationswinkel. In der Methode MoveRobotAsync können Start- und Endwinkel angegeben werden und der Arm bewegt sich zwischen diesen Winkeln.
Im LoadPortViewModel wird im Konstruktor lediglich die Liste an Slots initialisiert, die 25 Einträge enthält.
In TransferCommand wird für die Buttons benutzt, um zu steuern was passiert wenn auf Start und Pause geklickt wird.

# Views
MainWindow teilt das Hauptfenster in ein Grid ein, in dem LP 1 in der linken Spalte liegt, der Roboter Arm in der mittleren und LP2 in der rechten. Die Buttons liegen hierbei unten mittig.
Die LoadPorts und der Roboterarm haben hierbei ihre eigenen beiden Views, jeweils in LoadPortControl und RobotArmControl. LoadPortControl.xaml ordnet die Liste vertikal an. In RobotArmControl wird zusätzlich die Rotation des Armes beachtet.
WaferColorConverter ist dafür da sowohl die Slots, als auch den Roboter Arm entsprechend einzufärben, wenn ein Wafer vorhanden ist. Enthält das jeweilige Element ein Wafer wird es Blau eingefärbt, sonst grau.