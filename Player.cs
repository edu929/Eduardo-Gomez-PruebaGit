using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float VidaPlayer = 100.0f;
    public void Dmg(float dmg)
    {
        if (VidaPlayer >0)
        {
            VidaPlayer -= dmg;
        }
    }

       public bool Salud()
      {
          if (VidaPlayer > 0)
          {
              return true;
           }
           VidaPlayer = 0;
           return false; 
}

    public bool ComprobarPartida()
    {
           if (Salud())
            {
                return true;
            }
            return false;
    }    

    }
