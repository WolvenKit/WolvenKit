using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OdaCementBag : InteractiveDevice
	{
		private CBool _onCooldown;

		[Ordinal(96)] 
		[RED("onCooldown")] 
		public CBool OnCooldown
		{
			get => GetProperty(ref _onCooldown);
			set => SetProperty(ref _onCooldown, value);
		}

		public OdaCementBag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
