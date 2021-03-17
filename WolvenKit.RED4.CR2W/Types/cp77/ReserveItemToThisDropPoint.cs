using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReserveItemToThisDropPoint : ScriptableDeviceAction
	{
		private TweakDBID _item;

		[Ordinal(25)] 
		[RED("item")] 
		public TweakDBID Item
		{
			get => GetProperty(ref _item);
			set => SetProperty(ref _item, value);
		}

		public ReserveItemToThisDropPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
