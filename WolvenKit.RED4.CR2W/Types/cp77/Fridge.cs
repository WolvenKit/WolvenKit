using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Fridge : InteractiveDevice
	{
		private CHandle<AnimFeature_SimpleDevice> _animFeature;
		private CName _factOnDoorOpened;

		[Ordinal(93)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_SimpleDevice> AnimFeature
		{
			get
			{
				if (_animFeature == null)
				{
					_animFeature = (CHandle<AnimFeature_SimpleDevice>) CR2WTypeManager.Create("handle:AnimFeature_SimpleDevice", "animFeature", cr2w, this);
				}
				return _animFeature;
			}
			set
			{
				if (_animFeature == value)
				{
					return;
				}
				_animFeature = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("factOnDoorOpened")] 
		public CName FactOnDoorOpened
		{
			get
			{
				if (_factOnDoorOpened == null)
				{
					_factOnDoorOpened = (CName) CR2WTypeManager.Create("CName", "factOnDoorOpened", cr2w, this);
				}
				return _factOnDoorOpened;
			}
			set
			{
				if (_factOnDoorOpened == value)
				{
					return;
				}
				_factOnDoorOpened = value;
				PropertySet(this);
			}
		}

		public Fridge(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
