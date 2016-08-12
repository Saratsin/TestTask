Запустить Test.sln
1.Изменить логику нажатия на кнопку IOS проекта. Логика должна выполнятся во FirstViewModel, а не в FirstView. 
2.Почему плохо использовать подписку на событие через анономный метод += (sender,args) => {} ,а лучше использовать делегат ссылкой на метод += ButtonClicked.
3.Продублировать логику IOS проекта в Android проект (UI не важен).
4.Добавить еще одну ViewModel. Cоздать навигацию на событе click кнопки button c FirstViewModel на другую ViewModel.(Вторая ViewModel может быть с пустым представлением).Данная задача должна быть выполнена в IOS и Android проектах.

Відповідь:

2. Якщо ми потім хочемо відписати даний метод від події, то не матимемо можливості для цього, оскільки не знаємо посилання на цей анонімний метод. Наприклад:  

event EventHandler SomeEvent;  

void SubscribeEvents() 
{     
	SomeEvent+=EventHandler; //Can unsubscribe, method reference available     
	SomeEvent+= (sender, e) => { EventHandler(sender, e); }; //Don't have method reference, subscribed forever 
}  

void UnsubscribeEvents() 
{    
	SomeEvent-=EventHandler; //Unsubscribed by reference 
}  

void EventHandler(object sender, EventArgs e) 
{   
	//Some code to execute 
}