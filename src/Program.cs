namespace RustCE
{
  namespace Calculate
  {
    class Blocks
    {
      public Blocks() {}
      public void Doors(string option)
      {
        switch (option)
        {
          case "wood":
            Console.WriteLine("[RUST-CE] - Wooden Door:\n\n\t1 Rocket\n\t4 HV Rockets\n\t1 Incendiary Rocket\n\t1 C4\n\t2 Satchels\n\t19 Explosive Ammo\n\t6 Beam Cams\n\t45 Handmade Shells\n\t23 F1 Granades\n");
            break;
          case "sheet":
            Console.WriteLine("[RUST-CE] - Sheet Metal Door:\n\n\t2 Rockets\n\t11 HV Rockets\n\t1 C4\n\t4 Satchels\n\t63 Explosive Ammo\n\t18 Beam Cams\n\t50 F1 Grenades\n");
            break;
          case "metal":
            Console.WriteLine("[RUST-CE] - Sheet Metal Door:\n\n\t2 Rockets\n\t11 HV Rockets\n\t1 C4\n\t4 Satchels\n\t63 Explosive Ammo\n\t18 Beam Cams\n\t50 F1 Grenades\n");
            break;
          case "garage":
            Console.WriteLine("[RUST-CE] - Garage Door:\n\n\t3 Rockets\n\t25 HV Rockets\n\t2 C4s\n\t9 Satchels\n\t150 Explosive Ammo\n\t42 Beam Cams\n\t120 F1 Grenades\n");
            break;
          case "armored":
            Console.WriteLine("[RUST-CE] - Armored Door:\n\n\t4 Rockets\n\t34 HV Rockets\n\t2 C4s\n\t12 Satchels\n\t200 Explosive Ammo;\n\t56 Beam Cams\n\t160 F1 Grenades\n");
            break;
          case "help":
            break;
          default:
            Console.WriteLine("[RUST-CE] - Invalid option!\n");
            break;
        }
      }

      public void Placeables(string option)
      {
        switch (option)
        {
          case "tc":
            Console.WriteLine("[RUST-CE] - Tool Cupboard:\n\n\t1 Rocket\n\t2 HV Rockets\n\t1 Incendiary Rocket\n\t1 C4\n\t1 Satchel\n\t10 Explosive Ammo\n\t4 Beam Cams\n\t20 Handmade Shells\n\t43 F1 Grenades\n");
            break;
          case "tool_cupboard":
            Console.WriteLine("[RUST-CE] - Tool Cupboard:\n\n\t1 Rocket\n\t2 HV Rockets\n\t1 Incendiary Rocket\n\t1 C4\n\t1 Satchel\n\t10 Explosive Ammo\n\t4 Beam Cams\n\t20 Handmade Shells\n\t43 F1 Grenades\n");
            break;
          case "help":
            break;
          default:
            Console.WriteLine("[RUST-CE] - Invalid option!\n");
            break;
        }
      }

      public void Structures(string option)
      {
        switch (option)
        {
          case "wood":
            Console.WriteLine("[RUST-CE] - Wood Structure:\n\n\t2 Rockets\n\t9 HV Rockets\n\t1 Incendiary Rocket\n\t1 C4\n\t3 Satchels\n\t49 Explosive Ammo\n\t13 Beam Cams\n\t59 F1 Grenades\n");
            break;
          case "stone":
            Console.WriteLine("[RUST-CE] - Stone Structure:\n\n\t4 Rockets\n\t32 HV Rockets\n\t2 C4s\n\t10 Satchels\n\t185 Explosive Ammo\n\t46 Beam Cams\n\t182 F1 Grenades\n");
            break;
          case "metal":
            Console.WriteLine("[RUST-CE] - Metal Structure:\n\n\t8 Rockets\n\t67 HV Rockets\n\t4 C4s\n\t23 Satchels\n\t400 Explosive Ammo\n\t112 Beam Cams\n\t993 F1 Grenades\n");
            break;
          case "armored":
            Console.WriteLine("[RUST-CE] - Armored Structure:\n\n\t15 Rockets\n\t134 HV Rockets\n\t8 C4s\n\t46 Satchels\n\t799 Explosive Ammo\n\t223 Beam Cams\n\t1986 F1 Grenades\n");
            break;
          case "help":
            break;
          default:
            Console.WriteLine("[RUST-CE] - Invalid option!\n");
            break;
        }
      }
    }

    class Entities
    {
      public Entities() {}

      public void EventEntities(string option)
      {
        switch (option)
        {
          case "bradley":
            Console.WriteLine("[RUST-CE] - Bradley APC:\n\n\t6 Rockets\n\t15 Satchels\n\t128+ Explosive Ammo\n");
            break;
          case "apc":
            Console.WriteLine("[RUST-CE] - Bradley APC:\n\n\t6 Rockets\n\t15 Satchels\n\t128+ Explosive Ammo\n");
            break;
          case "heli":
            Console.WriteLine("[RUST-CE] - Patrol Helicopter:\n\n\t200+ Assault Rifle Bullets\n");
            break;
          case "attack_heli":
            Console.WriteLine("[RUST-CE] - Patrol Helicopter:\n\n\t200+ Assault Rifle Bullets\n");
            break;
          case "chinook":
            Console.WriteLine("[RUST-CE] - Chinook Crate:\n\n\t15 Minutes to Unlock (Hack)\n\tHeavy Scientists: 6 (Small Oil Rig) or 10 (Large Oil Rig)\n");
            break;
          case "ch47":
            Console.WriteLine("[RUST-CE] - Chinook Crate:\n\n\t15 Minutes to Unlock (Hack)\n\tHeavy Scientists: 6 (Small Oil Rig) or 10 (Large Oil Rig)\n");
            break;
          case "help":
            break;
          default:
            Console.WriteLine("[RUST-CE] - Invalid option!\n");
            break;
        };
      }
    }
  } // namespace Calculate

  class Type
  {
    public Type() {}

    public void Raid(string type, string option)
    {
      Calculate.Blocks blocks = new Calculate.Blocks();

      if (option != null)
      {
        switch (type)
        {
          case "door":
            blocks.Doors(option);

            if (option == "help")
            {
              Console.WriteLine("[RUST-CE] - Raid Commands:\n\nVALID OPTIONS:\ndoor:\n\twood, stone, metal (or metal_sheet), garage, armored\n");
            }

            break;
          case "structures":
            blocks.Structures(option);

            if (option == "help")
            {
              Console.WriteLine("[RUST-CE] - Structure Help:\n\nVALID OPTIONS:\nstructures (or structure):\n\twood, stone, metal, armored\n");
            }

            break;
          case "structure":
            blocks.Structures(option);

            if (option == "help")
            {
              Console.WriteLine("[RUST-CE] - Structure Help:\n\nVALID OPTIONS:\nstructures (or structure):\n\twood, stone, metal, armored\n");
            }

            break;
          case "placeables":
            blocks.Placeables(option);

            if (option == "help")
            {
              Console.WriteLine("[RUST-CE] - Placeables Options:\n\nVALID OPTIONS:\nPlaceables:\n\ttc (or tool_cupboard)\n");
            }

            break;
          case "help":
            break;
          default:
            Console.WriteLine("[RUST-CE] - No valid type provided, type '--raid help .' for more info\n");
            break;
        }

        if (type == "help")
        {
          Console.WriteLine("[RUST-CE] - Raid Commands:\n\nVALID TYPES:\n\tdoor 'option'\n\tstructures 'option'\n\tplaceables 'option'\n\nVALID OPTIONS:\n\tdoor, structures (or structure), placeables\n");
        }
      }
    }

    public void Events(string type, string option)
    {
      Calculate.Entities events = new Calculate.Entities();

      if (option != null)
      {
        switch (type)
        {
          case "entities":
            events.EventEntities(option);

            if (option == "help")
            {
              Console.WriteLine("[RUST-CE] - Entity Help:\n\nVALID OPTIONS:\n\tbradley (or apc), heli (or attack_heli)\n");
            }

            break;
          case "crate":
            events.EventEntities(option);

            if (option == "help")
            {
              Console.WriteLine("[RUST-CE] - Crate Help:\n\nVALID OPTIONS:\n\tchinook (or ch47)\n");
            }

            break;
          case "help":
            break;
          default:
            Console.WriteLine("[RUST-CE] - No valid option provided, type '--event help .' for more info\n");
            break;
        }

        if (type == "help")
        {
          Console.WriteLine("[RUST-CE] - Event Commands:\n\nVALID TYPES:\n\tentities 'option'\n\nVALID OPTIONS:\n\tbradley (or apc), heli (or attack_heli)\n");
        }
      }
    }
  }

  static class Program
  {
    static void Main(string[] args)
    { 
      // throw help message if the user tries to run the program without any arguments
      if (args.Length <= 0)
      {
        Console.WriteLine("[RUST-CE] - All Commands:\n\nVALID FUNCTION:\n\t--raid 'type'\n\t--event 'type'\n\nVALID TYPES:\n\tdoor 'option'\n\tstructures 'option'\n\tplaceables 'option'\n\tentities 'option'\n\tcrate 'option'\n\nVALID OPTIONS:\n\tdoors:\n\t\twood, stone, metal (or metal_sheet), garage, armored\n\tstructure (or structures):\n\t\twood, stone, metal, armored\n\tentities:\n\t\tbradley (or apc), heli (or attack_heli)\n\tcrate:\n\t\tchinook or (ch47)\n\tplaceables:\n\t\ttc (or tool_cupboard)\n");
        
        return;
      }

      Type type = new Type();

      switch (args[0]) // function
      {
        case "--raid":
          type.Raid(args[1], args[2]);
          break;
        case "--event":
          type.Events(args[1], args[2]);
          break;
        case "help":
          Console.WriteLine("[RUST-CE] - All Commands:\n\nVALID FUNCTION:\n\t--raid 'type'\n\t--event 'type'\n\nVALID TYPES:\n\tdoor 'option'\n\tstructures 'option'\n\tplaceables 'option'\n\tentities 'option'\n\tcrate 'option'\n\nVALID OPTIONS:\n\tdoors:\n\t\twood, stone, metal (or metal_sheet), garage, armored\n\tstructure (or structures):\n\t\twood, stone, metal, armored\n\tentities:\n\t\tbradley (or apc), heli (or attack_heli)\n\tcrate:\n\t\tchinook or (ch47)\n\tplaceables:\n\t\ttc (or tool_cupboard)\n");
          break;
        default:
          Console.WriteLine("[RUST-CE] - No valid function provided, type 'help .' for more info\n");
          break;
      }
    }
  }
} // namespace RustCE
