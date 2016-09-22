using Starcounter;

namespace KitchenSink
{
    partial class SortableList : Json
    {

        protected override void OnData()
        {
            base.OnData();

            SortableList.PersonElementJson person;

            person = this.Person.Add();
            person.FirstName = "Both guys";
            person.LastName = "from Dumb and Dumber";
            person.Number = 1;

            person = this.Person.Add();
            person.FirstName = "L. Ron";
            person.LastName = "Hubbard";
            person.Number = 2;

            person = this.Person.Add();
            person.FirstName = "My";
            person.LastName = "Brother";
            person.Number = 3;

            person = this.Person.Add();
            person.FirstName = "Donald";
            person.LastName = "Trump";
            person.Number = 4;

        }
        void Handle(Input.MoveUp action)
        {
            //What I want to do: check what number, first name and last name of the person on the row in
            //which the button was clicked. Save that in a temporary variable. Then, access the names and 
            //number of the person above, and save that on the space below. Then, use the info in the temporary
            //variable to write in the row above the row in which the button was clicked.
            //(Then pretty much opposite for MoveDown)

        }
        void Handle(Input.MoveDown action)
        {
          
        }

    }
}
