using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EntityNoticedPlayerPrereq : gameIScriptablePrereq
	{
		private CBool _isPlayerNoticed;
		private CUInt32 _valueToListen;

		[Ordinal(0)] 
		[RED("isPlayerNoticed")] 
		public CBool IsPlayerNoticed
		{
			get => GetProperty(ref _isPlayerNoticed);
			set => SetProperty(ref _isPlayerNoticed, value);
		}

		[Ordinal(1)] 
		[RED("valueToListen")] 
		public CUInt32 ValueToListen
		{
			get => GetProperty(ref _valueToListen);
			set => SetProperty(ref _valueToListen, value);
		}

		public EntityNoticedPlayerPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
