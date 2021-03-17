using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PuppetDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _isCrowd;
		private gamebbScriptID_Bool _hideNameplate;
		private gamebbScriptID_Bool _forceFriendlyCarry;
		private gamebbScriptID_Int32 _forcedCarryStyle;
		private gamebbScriptID_Bool _hasCPOMissionData;

		[Ordinal(0)] 
		[RED("IsCrowd")] 
		public gamebbScriptID_Bool IsCrowd
		{
			get => GetProperty(ref _isCrowd);
			set => SetProperty(ref _isCrowd, value);
		}

		[Ordinal(1)] 
		[RED("HideNameplate")] 
		public gamebbScriptID_Bool HideNameplate
		{
			get => GetProperty(ref _hideNameplate);
			set => SetProperty(ref _hideNameplate, value);
		}

		[Ordinal(2)] 
		[RED("ForceFriendlyCarry")] 
		public gamebbScriptID_Bool ForceFriendlyCarry
		{
			get => GetProperty(ref _forceFriendlyCarry);
			set => SetProperty(ref _forceFriendlyCarry, value);
		}

		[Ordinal(3)] 
		[RED("ForcedCarryStyle")] 
		public gamebbScriptID_Int32 ForcedCarryStyle
		{
			get => GetProperty(ref _forcedCarryStyle);
			set => SetProperty(ref _forcedCarryStyle, value);
		}

		[Ordinal(4)] 
		[RED("HasCPOMissionData")] 
		public gamebbScriptID_Bool HasCPOMissionData
		{
			get => GetProperty(ref _hasCPOMissionData);
			set => SetProperty(ref _hasCPOMissionData, value);
		}

		public PuppetDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
