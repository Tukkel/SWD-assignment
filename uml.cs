@startuml
Interface Animal{}
class Lion { }
class Pinguin { }
Interface Visitor { }
class Turist { }
class BigCartaker { }
class SmallCartaker { }

Lion-- |> Animal
Pinguin-- |> Animal

BigCartaker-- |> Visitor
SmallCartaker-- |> Visitor
Turist-- |> Visitor
Visitor-- > Lion
Visitor-- > Pinguin
Animal-- > Visitor
@enduml;




@startuml
    note over Client: The instansiation of Caretaker, Turist and Lion object
Client ->> Lion: accepts(visitor BigCaretaker)
activate Client
Lion -> BigCareTaker: visit(this { Lion object})
activate BigCareTaker
BigCareTaker -->> Lion: Hunger is decreased
    deactivate BigCareTaker
Client ->> Lion: accepts(visitor Turist)
Lion->Turist: visit(this { Lion object})
activate Turist
Turist -->> Lion: Hunger is increased
    deactivate Turist
    deactivate Client
    @enduml