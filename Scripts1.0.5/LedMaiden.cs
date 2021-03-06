﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gungeon;
using UnityEngine;
using ItemAPI;
using HutongGames.PlayMaker.Actions;


namespace Knives
{
    public class Led_Maiden : PlayerItem
    { 
        public static void Register()
        {
            string itemName = "Led Maiden";

            string resourceName = "Knives/Resources/led maiden";

            GameObject obj = new GameObject(itemName);

            var item = obj.AddComponent<Led_Maiden>();

            ItemBuilder.AddSpriteToObject(itemName, resourceName, obj);

            //Ammonomicon entry variables
            string shortDesc = "Stairwell to Gungeon";
            string longDesc =

                "A song created by a musical alchemist to harness the power of the lead maiden. " + 
                "Its chords becon forth great protection from seemingly nowhere.\n\n" +
                "But gungeoneers beware, at the end of the song the maidens WILL take what you owe them, whether you have payment or not.";

            //Adds the item to the gungeon item list, the ammonomicon, the loot table, etc.
            //Do this after ItemBuilder.AddSpriteToObject!
            ItemBuilder.SetupItem(item, shortDesc, longDesc, "ski");

            ItemBuilder.SetCooldownType(item, ItemBuilder.CooldownType.Damage, 375f);



            item.consumable = false;
            item.quality = PickupObject.ItemQuality.A;
        }
        protected override void DoEffect(PlayerController user)
        {
                
            AkSoundEngine.PostEvent("Play_ENM_ironmaiden_open_01", base.gameObject);
            AkSoundEngine.PostEvent("Play_ENM_ironmaiden_open_01", base.gameObject);
            AkSoundEngine.PostEvent("Play_ENM_ironmaiden_open_01", base.gameObject);
            user.GiveItem("glass_guon_stone");
            user.GiveItem("glass_guon_stone");
            user.GiveItem("glass_guon_stone");
            user.GiveItem("glass_guon_stone");
            user.GiveItem("glass_guon_stone");
            user.GiveItem("glass_guon_stone");
            user.GiveItem("glass_guon_stone");
            user.GiveItem("glass_guon_stone");
            user.GiveItem("glass_guon_stone");
            user.GiveItem("glass_guon_stone");
            user.GiveItem("glass_guon_stone");
            user.GiveItem("glass_guon_stone");
            user.GiveItem("glass_guon_stone");
            user.GiveItem("glass_guon_stone");
            user.GiveItem("glass_guon_stone");
            user.GiveItem("glass_guon_stone");
            user.GiveItem("glass_guon_stone");
            user.GiveItem("armor");
            float dura = 10f;
            StartCoroutine(ItemBuilder.HandleDuration(this, dura, user, EndEffect));
              

               

        }

        
        protected void EndEffect(PlayerController user)
        {
        var health = user.healthHaver;
           
        AkSoundEngine.PostEvent("Play_ENM_ironmaiden_shatter_01", base.gameObject);
        AkSoundEngine.PostEvent("Play_ENM_ironmaiden_shatter_01", base.gameObject);
            
        health.ApplyDamage( 1f, Vector2.zero,  "right in the feels");
            
            
        }

        }
    }


