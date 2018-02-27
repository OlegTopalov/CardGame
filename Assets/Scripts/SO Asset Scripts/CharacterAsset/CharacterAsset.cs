using UnityEngine;
using System.Collections;

public enum CharFraction{ Asylum, Necropolis, Haven, Stronghold, Preserve, Academy}

public class CharacterAsset : ScriptableObject 
{
	public CharFraction Class;
	public string ClassName;
	public int MaxHealth = 30;
	public string HeroPowerName;
	public Sprite AvatarImage;
    public Sprite HeroPowerIconImage;
    public Sprite AvatarBGImage;
    public Sprite HeroPowerBGImage;
    public Color32 AvatarBGTint;
    public Color32 HeroPowerBGTint;
	public Color32 FractionCardTint;
	public Color32 FractionRibbonsTint;
}
