using System.Collections;
using System;
using UnityEngine;
using System.Globalization;

namespace Mod
{
    public class Mod : MonoBehaviour
    {

        public static string ModTag = " <color=red>[PRMods]";
        public static string NameTag = " - <color=red>Possibly Remember";
        public static void Main()
        //public static Vector2(-4, 0);
        {
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Laser Pointer"),
                    NameOverride = "Red Keycard" + ModTag,
                    DescriptionOverride = "Red Keycard" + NameTag,
                    CategoryOverride = ModAPI.FindCategory("Misc."),
                    ThumbnailOverride = ModAPI.LoadSprite("sprites/redkeyc.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("sprites/redkeyc.png",4f,true); //Working on getting this texture to work as I want it to
                        UnityEngine.Object.Destroy(Instance.GetComponent<Collider2D>());
                        Instance.AddComponent<PolygonCollider2D>();
                        Instance.GetComponent<PolygonCollider2D>().pathCount = 2;
                        Instance.GetComponent<PolygonCollider2D>().autoTiling = true;
                        //UnityEngine.Object.Destroy(Instance.GetComponent<LaserReceiverBehaviour>().Light);
                        Instance.GetComponent<LaserBehaviour>().barrelPosition = new Vector2(0, 0);
                    }
                }
            );
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Laser Reciever"),
                    NameOverride = "Red Reciever" + ModTag,
                    DescriptionOverride = "Put Red Keycard here," + NameTag,
                    CategoryOverride = ModAPI.FindCategory("Misc."),
                    ThumbnailOverride = ModAPI.LoadSprite("sprites/redkeyr.png")
                    AfterSpawn = (Instance) =>
                    {
                        //Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("sprites/redkeyr.png");
                        //UnityEngine.Object.Destroy(Instance.GetComponent<Collider2D>());
                        //Instance.GetComponent<LaserBehaviour>().PhysicalBehaviour.spriteRenderer.sprite = ModAPI.LoadSprite("sprites/redkeyr.png");
                        //Instance.GetComponent<LaserBehaviour>().barrelPosition = new Vector2(-4,0);
                        //Instance.AddComponent<PolygonCollider2D>();
                        //Instance.GetComponent<PolygonCollider2D>().pathCount = 2;
                        //Instance.GetComponent<PolygonCollider2D>().autoTiling = true;
                        //Instance.FixColliders();
                    }
                }
            );
        }
    }
    public class Reciever : object
    {

    }
}