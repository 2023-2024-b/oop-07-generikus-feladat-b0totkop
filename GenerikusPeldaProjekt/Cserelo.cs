namespace GenerikusPeldaProjekt
{
    public class Cserelo<T> where T : class
    {
        // Készítsen generikus osztályt amely tetszőleges két típust felcserél
        public static void Csere(ref T elso, ref T masodik)
        {
            T temp = elso;
            elso = masodik;
            masodik = temp;
        }
    }
}
