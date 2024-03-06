using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using JuegoBlazor.Modelo;

namespace JuegoBlazor.Repositorio.DBContext;

public partial class L2testGame2Context : DbContext
{
    public L2testGame2Context()
    {
    }

    public L2testGame2Context(DbContextOptions<L2testGame2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<ArmorPart> ArmorParts { get; set; }

    public virtual DbSet<ArmorType> ArmorTypes { get; set; }

    public virtual DbSet<BaseHpcoef> BaseHpcoefs { get; set; }

    public virtual DbSet<BaseMpchar> BaseMpchars { get; set; }

    public virtual DbSet<Character> Characters { get; set; }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<Grade> Grades { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<ItemsArmor> ItemsArmors { get; set; }

    public virtual DbSet<ItemsJewellery> ItemsJewelleries { get; set; }

    public virtual DbSet<ItemsType> ItemsTypes { get; set; }

    public virtual DbSet<ItemsWeapon> ItemsWeapons { get; set; }

    public virtual DbSet<JewelleryType> JewelleryTypes { get; set; }

    public virtual DbSet<Race> Races { get; set; }

    public virtual DbSet<StatBonus> StatBonus { get; set; }

    public virtual DbSet<SubRace> SubRaces { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserCharacter> UserCharacters { get; set; }

    public virtual DbSet<UserItem> UserItems { get; set; }

    public virtual DbSet<WeaponEnchant> WeaponEnchants { get; set; }

    public virtual DbSet<WeaponType> WeaponTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ArmorPart>(entity =>
        {
            entity.HasKey(e => e.IdArmorPart).HasName("PK__ArmorPar__ADDC74FAB82D2555");

            entity.ToTable("ArmorPart");

            entity.Property(e => e.IdArmorPart).HasColumnName("Id_ArmorPart");
            entity.Property(e => e.Descripcion).HasMaxLength(50);
        });

        modelBuilder.Entity<ArmorType>(entity =>
        {
            entity.HasKey(e => e.IdArmorType).HasName("PK__ArmorTyp__6C01C44EA66324B4");

            entity.ToTable("ArmorType");

            entity.Property(e => e.IdArmorType).HasColumnName("Id_ArmorType");
            entity.Property(e => e.Descripcion).HasMaxLength(50);
        });

        modelBuilder.Entity<BaseHpcoef>(entity =>
        {
            entity.HasKey(e => e.IdBaseHpcoef).HasName("PK__BaseHPCo__49702F89862D8ABE");

            entity.ToTable("BaseHPCoef");

            entity.Property(e => e.IdBaseHpcoef).HasColumnName("Id_BaseHPCoef");
        });

        modelBuilder.Entity<BaseMpchar>(entity =>
        {
            entity.HasKey(e => e.CharLevel).HasName("PK__BaseMPCh__D4DD85EB89CB6CF9");

            entity.ToTable("BaseMPChar");
        });

        modelBuilder.Entity<Character>(entity =>
        {
            entity.HasKey(e => e.IdCharacter).HasName("PK__Characte__CDD73BE0F4477AE2");

            entity.Property(e => e.IdCharacter).HasColumnName("Id_Character");
            entity.Property(e => e.CharacterName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdClass).HasColumnName("Id_Class");

            entity.HasOne(d => d.Earring1Navigation).WithMany(p => p.CharacterEarring1Navigations)
                .HasForeignKey(d => d.Earring1)
                .HasConstraintName("FK__Character__Earri__5FB337D6");

            entity.HasOne(d => d.Earring2Navigation).WithMany(p => p.CharacterEarring2Navigations)
                .HasForeignKey(d => d.Earring2)
                .HasConstraintName("FK__Character__Earri__60A75C0F");

            entity.HasOne(d => d.GlovesNavigation).WithMany(p => p.CharacterGlovesNavigations)
                .HasForeignKey(d => d.Gloves)
                .HasConstraintName("FK__Character__Glove__5BE2A6F2");

            entity.HasOne(d => d.HelmetNavigation).WithMany(p => p.CharacterHelmetNavigations)
                .HasForeignKey(d => d.Helmet)
                .HasConstraintName("FK__Character__Helme__5AEE82B9");

            entity.HasOne(d => d.IdClassNavigation).WithMany(p => p.Characters)
                .HasForeignKey(d => d.IdClass)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Character__Id_Cl__571DF1D5");

            entity.HasOne(d => d.LowerBodyNavigation).WithMany(p => p.CharacterLowerBodyNavigations)
                .HasForeignKey(d => d.LowerBody)
                .HasConstraintName("FK__Character__Lower__59FA5E80");

            entity.HasOne(d => d.NecklaceNavigation).WithMany(p => p.CharacterNecklaceNavigations)
                .HasForeignKey(d => d.Necklace)
                .HasConstraintName("FK__Character__Neckl__5EBF139D");

            entity.HasOne(d => d.Ring1Navigation).WithMany(p => p.CharacterRing1Navigations)
                .HasForeignKey(d => d.Ring1)
                .HasConstraintName("FK__Character__Ring1__619B8048");

            entity.HasOne(d => d.Ring2Navigation).WithMany(p => p.CharacterRing2Navigations)
                .HasForeignKey(d => d.Ring2)
                .HasConstraintName("FK__Character__Ring2__628FA481");

            entity.HasOne(d => d.ShieldNavigation).WithMany(p => p.CharacterShieldNavigations)
                .HasForeignKey(d => d.Shield)
                .HasConstraintName("FK__Character__Shiel__5DCAEF64");

            entity.HasOne(d => d.ShoesNavigation).WithMany(p => p.CharacterShoesNavigations)
                .HasForeignKey(d => d.Shoes)
                .HasConstraintName("FK__Character__Shoes__5CD6CB2B");

            entity.HasOne(d => d.UpperBodyNavigation).WithMany(p => p.CharacterUpperBodyNavigations)
                .HasForeignKey(d => d.UpperBody)
                .HasConstraintName("FK__Character__Upper__59063A47");

            entity.HasOne(d => d.WeaponNavigation).WithMany(p => p.Characters)
                .HasForeignKey(d => d.Weapon)
                .HasConstraintName("FK__Character__Weapo__5812160E");
        });

        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.IdClass).HasName("PK__Classes__E30692FE0E54334A");

            entity.Property(e => e.IdClass)
                .ValueGeneratedNever()
                .HasColumnName("Id_Class");
            entity.Property(e => e.ClassName).HasMaxLength(50);
            entity.Property(e => e.IdBaseHpcoef).HasColumnName("Id_BaseHPCoef");
            entity.Property(e => e.IdSubRace).HasColumnName("Id_SubRace");
            entity.Property(e => e.ParentId).HasColumnName("Parent_Id");

            entity.HasOne(d => d.IdBaseHpcoefNavigation).WithMany(p => p.Classes)
                .HasForeignKey(d => d.IdBaseHpcoef)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Classes__Id_Base__2F10007B");

            entity.HasOne(d => d.IdSubRaceNavigation).WithMany(p => p.Classes)
                .HasForeignKey(d => d.IdSubRace)
                .HasConstraintName("FK__Classes__Id_SubR__2D27B809");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK__Classes__Parent___2E1BDC42");
        });

        modelBuilder.Entity<Grade>(entity =>
        {
            entity.HasKey(e => e.IdGrade).HasName("PK__Grades__ADBED2A86169F4D0");

            entity.Property(e => e.IdGrade).HasColumnName("Id_Grade");
            entity.Property(e => e.Descripcion).HasMaxLength(255);
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.IdItem).HasName("PK__Items__F325AAC4432468CF");

            entity.Property(e => e.IdItem)
                .ValueGeneratedNever()
                .HasColumnName("Id_Item");
            entity.Property(e => e.IdItemType).HasColumnName("Id_ItemType");
            entity.Property(e => e.ItemName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdItemTypeNavigation).WithMany(p => p.Items)
                .HasForeignKey(d => d.IdItemType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Items__Id_ItemTy__44FF419A");
        });

        modelBuilder.Entity<ItemsArmor>(entity =>
        {
            entity.HasKey(e => e.IdItemArmor).HasName("PK__Items_Ar__FABC00342DCAB363");

            entity.ToTable("Items_Armors");

            entity.Property(e => e.IdItemArmor).HasColumnName("Id_ItemArmor");
            entity.Property(e => e.IdArmorPart).HasColumnName("Id_ArmorPart");
            entity.Property(e => e.IdArmorType).HasColumnName("Id_ArmorType");
            entity.Property(e => e.IdGrade).HasColumnName("Id_Grade");
            entity.Property(e => e.IdItem).HasColumnName("Id_Item");

            entity.HasOne(d => d.IdArmorPartNavigation).WithMany(p => p.ItemsArmors)
                .HasForeignKey(d => d.IdArmorPart)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Items_Arm__Id_Ar__4E88ABD4");

            entity.HasOne(d => d.IdArmorTypeNavigation).WithMany(p => p.ItemsArmors)
                .HasForeignKey(d => d.IdArmorType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Items_Arm__Id_Ar__4D94879B");

            entity.HasOne(d => d.IdGradeNavigation).WithMany(p => p.ItemsArmors)
                .HasForeignKey(d => d.IdGrade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Items_Arm__Id_Gr__4F7CD00D");

            entity.HasOne(d => d.IdItemNavigation).WithMany(p => p.ItemsArmors)
                .HasForeignKey(d => d.IdItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Items_Arm__Id_It__4CA06362");
        });

        modelBuilder.Entity<ItemsJewellery>(entity =>
        {
            entity.HasKey(e => e.IdItemJewellery).HasName("PK__Items_Je__3FB055BC5BD81E76");

            entity.ToTable("Items_Jewellery");

            entity.Property(e => e.IdItemJewellery).HasColumnName("Id_ItemJewellery");
            entity.Property(e => e.IdGrade).HasColumnName("Id_Grade");
            entity.Property(e => e.IdItem).HasColumnName("Id_Item");
            entity.Property(e => e.IdJewelleryType).HasColumnName("Id_JewelleryType");
            entity.Property(e => e.MDef).HasColumnName("mDef");

            entity.HasOne(d => d.IdGradeNavigation).WithMany(p => p.ItemsJewelleries)
                .HasForeignKey(d => d.IdGrade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Items_Jew__Id_Gr__5441852A");

            entity.HasOne(d => d.IdItemNavigation).WithMany(p => p.ItemsJewelleries)
                .HasForeignKey(d => d.IdItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Items_Jew__Id_It__52593CB8");

            entity.HasOne(d => d.IdJewelleryTypeNavigation).WithMany(p => p.ItemsJewelleries)
                .HasForeignKey(d => d.IdJewelleryType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Items_Jew__Id_Je__534D60F1");
        });

        modelBuilder.Entity<ItemsType>(entity =>
        {
            entity.HasKey(e => e.IdItemsType).HasName("PK__ItemsTyp__38B9A3AEF1628B71");

            entity.Property(e => e.IdItemsType).HasColumnName("Id_ItemsType");
            entity.Property(e => e.Descripcion).HasMaxLength(50);
        });

        modelBuilder.Entity<ItemsWeapon>(entity =>
        {
            entity.HasKey(e => e.IdItemWeapon).HasName("PK__Items_We__0192CB9F9E57AEB0");

            entity.ToTable("Items_Weapons");

            entity.Property(e => e.IdItemWeapon).HasColumnName("Id_ItemWeapon");
            entity.Property(e => e.IdGrade).HasColumnName("Id_Grade");
            entity.Property(e => e.IdItem).HasColumnName("Id_Item");
            entity.Property(e => e.IdWeaponType).HasColumnName("Id_WeaponType");
            entity.Property(e => e.MAtk).HasColumnName("mAtk");
            entity.Property(e => e.PAtk).HasColumnName("pAtk");

            entity.HasOne(d => d.IdGradeNavigation).WithMany(p => p.ItemsWeapons)
                .HasForeignKey(d => d.IdGrade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Items_Wea__Id_Gr__49C3F6B7");

            entity.HasOne(d => d.IdItemNavigation).WithMany(p => p.ItemsWeapons)
                .HasForeignKey(d => d.IdItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Items_Wea__Id_It__47DBAE45");

            entity.HasOne(d => d.IdWeaponTypeNavigation).WithMany(p => p.ItemsWeapons)
                .HasForeignKey(d => d.IdWeaponType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Items_Wea__Id_We__48CFD27E");
        });

        modelBuilder.Entity<JewelleryType>(entity =>
        {
            entity.HasKey(e => e.IdJewelleryType).HasName("PK__Jeweller__D6C699F029248888");

            entity.ToTable("JewelleryType");

            entity.Property(e => e.IdJewelleryType).HasColumnName("Id_JewelleryType");
            entity.Property(e => e.Descripcion).HasMaxLength(50);
        });

        modelBuilder.Entity<Race>(entity =>
        {
            entity.HasKey(e => e.IdRace).HasName("PK__Races__36C5F293F7192AEF");

            entity.Property(e => e.IdRace).HasColumnName("Id_Race");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StatBonus>(entity =>
        {
            entity.HasKey(e => e.IdStatBonus).HasName("PK__StatBonu__D22FCDBEEE5125CD");

            entity.Property(e => e.IdStatBonus).HasColumnName("Id_StatBonus");
        });

        modelBuilder.Entity<SubRace>(entity =>
        {
            entity.HasKey(e => e.IdSubRace).HasName("PK__SubRaces__D344999F8FE9FBC6");

            entity.Property(e => e.IdSubRace).HasColumnName("Id_SubRace");
            entity.Property(e => e.Descripcion).HasMaxLength(50);
            entity.Property(e => e.IdRace).HasColumnName("Id_Race");

            entity.HasOne(d => d.IdRaceNavigation).WithMany(p => p.SubRaces)
                .HasForeignKey(d => d.IdRace)
                .HasConstraintName("FK__SubRaces__Id_Rac__286302EC");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.IdUser).HasName("PK__Users__D03DEDCB34EBD587");

            entity.Property(e => e.IdUser).HasColumnName("Id_User");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserPassword)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserCharacter>(entity =>
        {
            entity.HasKey(e => e.IdUserCharacter).HasName("PK__User_Cha__F19839876EC53408");

            entity.ToTable("User_Characters");

            entity.Property(e => e.IdUserCharacter).HasColumnName("Id_User_Character");
            entity.Property(e => e.IdCharacter).HasColumnName("Id_Character");
            entity.Property(e => e.IdUser).HasColumnName("Id_User");

            entity.HasOne(d => d.IdCharacterNavigation).WithMany(p => p.UserCharacters)
                .HasForeignKey(d => d.IdCharacter)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__User_Char__Id_Ch__66603565");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.UserCharacters)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__User_Char__Id_Us__656C112C");
        });

        modelBuilder.Entity<UserItem>(entity =>
        {
            entity.HasKey(e => e.IdUserItem).HasName("PK__User_Ite__EFC09BA4D55B53CB");

            entity.ToTable("User_Items");

            entity.Property(e => e.IdUserItem).HasColumnName("Id_User_Item");
            entity.Property(e => e.IdItem).HasColumnName("Id_Item");
            entity.Property(e => e.IdUser).HasColumnName("Id_User");

            entity.HasOne(d => d.IdItemNavigation).WithMany(p => p.UserItems)
                .HasForeignKey(d => d.IdItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__User_Item__Id_It__6A30C649");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.UserItems)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__User_Item__Id_Us__693CA210");
        });

        modelBuilder.Entity<WeaponEnchant>(entity =>
        {
            entity.HasKey(e => e.IdWeaponEnchant).HasName("PK__WeaponEn__9FB5E43469921982");

            entity.ToTable("WeaponEnchant");

            entity.Property(e => e.IdWeaponEnchant).HasColumnName("Id_WeaponEnchant");
            entity.Property(e => e.IdGrade).HasColumnName("Id_Grade");
            entity.Property(e => e.IdWeaponType).HasColumnName("Id_WeaponType");

            entity.HasOne(d => d.IdGradeNavigation).WithMany(p => p.WeaponEnchants)
                .HasForeignKey(d => d.IdGrade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__WeaponEnc__Id_Gr__398D8EEE");

            entity.HasOne(d => d.IdWeaponTypeNavigation).WithMany(p => p.WeaponEnchants)
                .HasForeignKey(d => d.IdWeaponType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__WeaponEnc__Id_We__3A81B327");
        });

        modelBuilder.Entity<WeaponType>(entity =>
        {
            entity.HasKey(e => e.IdWeaponType).HasName("PK__WeaponTy__91354F5B7E8BAC3C");

            entity.ToTable("WeaponType");

            entity.Property(e => e.IdWeaponType).HasColumnName("Id_WeaponType");
            entity.Property(e => e.Descripcion).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
