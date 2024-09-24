using System;


//chaque classe doit etre ouvert a l'extension fermer a la modification 
namespace OpenClosedPrinciple
{
    public abstract class Shape
    {
        public abstract int  Surface  { get; }
    }
}
