using System.Collections;
using System;
using UnityEngine;
using System.Globalization;

namespace Mod
{
    public class Mod : MonoBehaviour
    {

        public static string ModTag = " <color=red>[PRMods]"; //Whilst not required, modded items should contain 'tags' at the end of their names to prevent errors in which two mods have an item of the same name.
        public static string NameTag = " - <color=red>Possibly Remember";
        public static void Main()
        {
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Brick"),
                    NameOverride = "Red Keycard" + ModTag,
                    DescriptionOverride = "Red Keycard" + NameTag,
                    CategoryOverride = ModAPI.FindCategory("Misc."),
                    ThumbnailOverride = ModAPI.LoadSprite("redkeyc.png"), //Doesn't exist yet!
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("redkeyc.png"); //Doesn't exist yet!
                        Instance.GetComponent<Collider2D>().IsTouching();
                    }
                }
            );
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Brick"),
                    NameOverride = "Red Reciever" + ModTag,
                    DescriptionOverride = "Put Red Keycard here," + NameTag,
                    CategoryOverride = ModAPI.FindCategory("Misc."),
                    ThumbnailOverride = ModAPI.LoadSprite("redkeyc.png"), //Doesn't exist yet!
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("redkeyr.png"); //Doesn't exist yet!
                    }
                }
            );
        }
    }
}