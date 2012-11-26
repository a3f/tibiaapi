using Tibia.Addresses;

namespace Tibia
{
    public partial class Version
    {
        public static void SetVersion850()
        {
            BattleList.Start = 0x632F30;
            BattleList.End = 0x632F30 + 0xA0 * 250;
            BattleList.StepCreatures = 0xA0;
            BattleList.MaxCreatures = 250;

            Client.StartTime = 0x7913F8;
            Client.XTeaKey = 0x78BF34;
            Client.SocketStruct = 0x78BF08;
            Client.RecvPointer = 0x5B05DC;
            Client.SendPointer = 0x5B0608;
            Client.FrameRatePointer = 0x7900DC;
            Client.FrameRateCurrentOffset = 0x60;
            Client.FrameRateLimitOffset = 0x58;
            Client.MultiClient = 0x506794;
            Client.Status = 0x78F598;
            Client.SafeMode = 0x78C35C;
            Client.FollowMode = Client.SafeMode + 4;
            Client.AttackMode = Client.FollowMode + 4;
            Client.ActionState = 0x78F5F8;
            Client.LastMSGText = 0x791668;
            Client.LastMSGAuthor = Client.LastMSGText - 0x28;
            Client.StatusbarText = 0x791418;
            Client.StatusbarTime = Client.StatusbarText - 4;
            Client.ClickId = 0x78F634;
            Client.ClickCount = Client.ClickId + 4;
            Client.ClickZ = Client.ClickId - 0x68;
            Client.SeeId = Client.ClickId + 12;
            Client.SeeCount = Client.SeeId + 4;
            Client.SeeZ = Client.SeeId - 0x68;
            Client.ClickContextMenuItemId = 0x78F640;
            Client.ClickContextMenuItemGroundId = 0x78F64C;
            Client.ClickContextMenuCreatureId = 0x78F59C;
            Client.SeeText = 0;
            Client.LoginServerStart = 0x786E70;
            Client.StepLoginServer = 112;
            Client.DistancePort = 100;
            Client.MaxLoginServers = 10;
            Client.RSA = 0x5B0610;
            Client.LoginCharList = 0x78F54C;
            Client.LoginCharListLength = Client.LoginCharList + 4;
            Client.LoginSelectedChar = 0x78F548;
            Client.GameWindowRectPointer = 0x63E8D4;
            Client.GameWindowBar = 0x641C40;
            Client.DatPointer = 0x78BF54;
            Client.EventTriggerPointer = 0x519770;
            Client.DialogPointer = 0x641C3C;
            Client.DialogLeft = 0x14;
            Client.DialogTop = 0x18;
            Client.DialogWidth = 0x1C;
            Client.DialogHeight = 0x20;
            Client.DialogCaption = 0x50;
            Client.LastRcvPacket = 0x7876E8;
            Client.DecryptCall = 0x45B845;
            Client.LoginAccountNum = 0;
            Client.LoginPassword = 0x78F554;
            Client.LoginAccount = Client.LoginPassword + 32;
            Client.LoginPatch = 0;
            Client.LoginPatch2 = 0;
            Client.LoginPatchOrig = new byte[] { 0xE8, 0x0D, 0x1D, 0x09, 0x00 };
            Client.LoginPatchOrig2 = new byte[] { 0xE8, 0xC8, 0x15, 0x09, 0x00 };
            Client.ParserFunc = 0x45B810;
            Client.GetNextPacketCall = 0x45B845;
            Client.RecvStream = 0x78BF24;

            Container.Start = 0x63F388;
            Container.StepContainer = 492;
            Container.StepSlot = 12;
            Container.MaxContainers = 16;
            Container.MaxStack = 100;
            Container.DistanceIsOpen = 0;
            Container.DistanceId = 4;
            Container.DistanceName = 16;
            Container.DistanceVolume = 48;
            Container.DistanceAmount = 56;
            Container.DistanceItemId = 60;
            Container.DistanceItemCount = 64;
            Container.End = Container.Start + (Container.MaxContainers * Container.StepContainer);

            ContextMenus.AddContextMenuPtr = 0x451830;
            ContextMenus.OnClickContextMenuPtr = 0x44DFD0;
            ContextMenus.OnClickContextMenuVf = 0x5B5B98;
            ContextMenus.AddSetOutfitContextMenu = 0x452762;
            ContextMenus.AddPartyActionContextMenu = 0x4527B3;
            ContextMenus.AddCopyNameContextMenu = 0x4527CA;
            ContextMenus.AddTradeWithContextMenu = 0x4523D9;
            ContextMenus.AddLookContextMenu = 0x45228F;

            Creature.DistanceId = 0;
            Creature.DistanceType = 3;
            Creature.DistanceName = 4;
            Creature.DistanceX = 36;
            Creature.DistanceY = 40;
            Creature.DistanceZ = 44;
            Creature.DistanceScreenOffsetHoriz = 48;
            Creature.DistanceScreenOffsetVert = 52;
            Creature.DistanceIsWalking = 76;
            Creature.DistanceWalkSpeed = 140;
            Creature.DistanceDirection = 80;
            Creature.DistanceIsVisible = 144;
            Creature.DistanceBlackSquare = 132;
            Creature.DistanceLight = 120;
            Creature.DistanceLightColor = 124;
            Creature.DistanceHPBar = 136;
            Creature.DistanceSkull = 148;
            Creature.DistanceParty = 152;
            Creature.DistanceOutfit = 96;
            Creature.DistanceColorHead = 100;
            Creature.DistanceColorBody = 104;
            Creature.DistanceColorLegs = 108;
            Creature.DistanceColorFeet = 112;
            Creature.DistanceAddon = 116;

            DatItem.StepItems = 0x50;
            DatItem.Width = 0;
            DatItem.Height = 4;
            DatItem.MaxSizeInPixels = 8;
            DatItem.Layers = 12;
            DatItem.PatternX = 16;
            DatItem.PatternY = 20;
            DatItem.PatternDepth = 24;
            DatItem.Phase = 28;
            DatItem.Sprite = 32;
            DatItem.Flags = 36;
            DatItem.CanLookAt = 40;
            DatItem.WalkSpeed = 44;
            DatItem.TextLimit = 48;
            DatItem.LightRadius = 52;
            DatItem.LightColor = 56;
            DatItem.ShiftX = 60;
            DatItem.ShiftY = 64;
            DatItem.WalkHeight = 68;
            DatItem.Automap = 72;
            DatItem.LensHelp = 76;

            DrawItem.DrawItemFunc = 0x4B0BC0;

            DrawSkin.DrawSkinFunc = 0x4B4860;

            Hotkey.SendAutomaticallyStart = 0x78C558;
            Hotkey.SendAutomaticallyStep = 0x01;
            Hotkey.TextStart = 0x78C580;
            Hotkey.TextStep = 0x100;
            Hotkey.ObjectStart = 0x78C4C8;
            Hotkey.ObjectStep = 0x04;
            Hotkey.ObjectUseTypeStart = 0x78C3A8;
            Hotkey.ObjectUseTypeStep = 0x04;
            Hotkey.MaxHotkeys = 36;

            Map.MapPointer = 0x646790;
            Map.StepTile = 168;
            Map.StepTileObject = 12;
            Map.DistanceTileObjectCount = 0;
            Map.DistanceTileObjects = 4;
            Map.DistanceObjectId = 0;
            Map.DistanceObjectData = 4;
            Map.DistanceObjectDataEx = 8;
            Map.MaxTileObjects = 10;
            Map.MaxX = 18;
            Map.MaxY = 14;
            Map.MaxZ = 8;
            Map.MaxTiles = 2016;
            Map.ZAxisDefault = 7;
            Map.NameSpy1 = 0x4ED239;
            Map.NameSpy2 = 0x4ED243;
            Map.NameSpy1Default = 19061;
            Map.NameSpy2Default = 16501;
            Map.LevelSpy1 = 0x4EF0EA;
            Map.LevelSpy2 = 0x4EF1EF;
            Map.LevelSpy3 = 0x4EF270;
            Map.LevelSpyPtr = 0x63E8D4;
            Map.LevelSpyAdd1 = 28;
            Map.LevelSpyAdd2 = 0x2A88;
            Map.LevelSpyDefault = new byte[] { 0x89, 0x86, 0x88, 0x2A, 0x00, 0x00 };
            Map.RevealInvisible1 = 0x45F6F3;
            Map.RevealInvisible2 = 0x4EC505;
            Map.FullLightNop = 0x4E59C9;
            Map.FullLightAdr = 0x4E59CC;
            Map.FullLightNopDefault = new byte[] { 0x7E, 0x05 };
            Map.FullLightNopEdited = new byte[] { 0x90, 0x90 };
            Map.FullLightAdrDefault = 0x80;
            Map.FullLightAdrEdited = 0xFF;

            Player.Experience = 0x632EC4;
            Player.Flags = Player.Experience - 108;
            Player.Id = Player.Experience + 12;
            Player.Health = Player.Experience + 8;
            Player.HealthMax = Player.Experience + 4;
            Player.Level = Player.Experience - 4;
            Player.MagicLevel = Player.Experience - 8;
            Player.LevelPercent = Player.Experience - 12;
            Player.MagicLevelPercent = Player.Experience - 16;
            Player.Mana = Player.Experience - 20;
            Player.ManaMax = Player.Experience - 24;
            Player.Soul = Player.Experience - 28;
            Player.Stamina = Player.Experience - 32;
            Player.Capacity = Player.Experience - 36;
            Player.FistPercent = 0x632E5C;
            Player.ClubPercent = Player.FistPercent + 4;
            Player.SwordPercent = Player.FistPercent + 8;
            Player.AxePercent = Player.FistPercent + 12;
            Player.DistancePercent = Player.FistPercent + 16;
            Player.ShieldingPercent = Player.FistPercent + 20;
            Player.FishingPercent = Player.FistPercent + 24;
            Player.Fist = Player.FistPercent + 28;
            Player.Club = Player.FistPercent + 32;
            Player.Sword = Player.FistPercent + 36;
            Player.Axe = Player.FistPercent + 40;
            Player.Distance = Player.FistPercent + 44;
            Player.Shielding = Player.FistPercent + 48;
            Player.Fishing = Player.FistPercent + 52;
            Player.SlotHead = 0x63F310;
            Player.SlotNeck = Player.SlotHead + 12;
            Player.SlotBackpack = Player.SlotHead + 24;
            Player.SlotArmor = Player.SlotHead + 36;
            Player.SlotRight = Player.SlotHead + 48;
            Player.SlotLeft = Player.SlotHead + 60;
            Player.SlotLegs = Player.SlotHead + 72;
            Player.SlotFeet = Player.SlotHead + 84;
            Player.SlotRing = Player.SlotHead + 96;
            Player.SlotAmmo = Player.SlotHead + 108;
            Player.MaxSlots = 11;
            Player.DistanceSlotCount = 4;
            Player.CurrentTileToGo = 0x632ED8;
            Player.TilesToGo = 0x632EDC;
            Player.GoToX = Player.Experience + 80;
            Player.GoToY = Player.GoToX - 4;
            Player.GoToZ = Player.GoToX - 8;
            Player.RedSquare = 0x632E9C;
            Player.GreenSquare = Player.RedSquare - 4;
            Player.WhiteSquare = Player.GreenSquare - 8;
            Player.AccessN = 0;
            Player.AccessS = 0;
            Player.TargetId = Player.RedSquare;
            Player.TargetBattlelistId = Player.TargetId - 8;
            Player.TargetBattlelistType = Player.TargetId - 5;
            Player.TargetType = Player.TargetId + 3;
            Player.Z = 0x641C78;

            TextDisplay.PrintName = 0x4F0221;
            TextDisplay.PrintFPS = 0x459728;
            TextDisplay.ShowFPS = 0x630B74;
            TextDisplay.PrintTextFunc = 0x4B0000;
            TextDisplay.NopFPS = 0x459664;

            Vip.Start = 0x630BF0;
            Vip.StepPlayers = 0x2C;
            Vip.MaxPlayers = 200;
            Vip.DistanceId = 0;
            Vip.DistanceName = 4;
            Vip.DistanceStatus = 34;
            Vip.DistanceIcon = 40;
            Vip.End = Vip.Start + (Vip.StepPlayers * Vip.MaxPlayers);
        }
    }
}