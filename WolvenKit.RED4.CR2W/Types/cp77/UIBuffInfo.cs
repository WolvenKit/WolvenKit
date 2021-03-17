using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIBuffInfo : gameuiBuffInfo
	{
		private CBool _isBuff;
		private CUInt32 _stackCount;

		[Ordinal(2)] 
		[RED("isBuff")] 
		public CBool IsBuff
		{
			get => GetProperty(ref _isBuff);
			set => SetProperty(ref _isBuff, value);
		}

		[Ordinal(3)] 
		[RED("stackCount")] 
		public CUInt32 StackCount
		{
			get => GetProperty(ref _stackCount);
			set => SetProperty(ref _stackCount, value);
		}

		public UIBuffInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
