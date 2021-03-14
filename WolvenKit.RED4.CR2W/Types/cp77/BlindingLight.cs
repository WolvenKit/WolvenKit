using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BlindingLight : BasicDistractionDevice
	{
		private CHandle<gameStaticTriggerAreaComponent> _areaComponent;
		private CBool _highLightActive;

		[Ordinal(99)] 
		[RED("areaComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> AreaComponent
		{
			get
			{
				if (_areaComponent == null)
				{
					_areaComponent = (CHandle<gameStaticTriggerAreaComponent>) CR2WTypeManager.Create("handle:gameStaticTriggerAreaComponent", "areaComponent", cr2w, this);
				}
				return _areaComponent;
			}
			set
			{
				if (_areaComponent == value)
				{
					return;
				}
				_areaComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(100)] 
		[RED("highLightActive")] 
		public CBool HighLightActive
		{
			get
			{
				if (_highLightActive == null)
				{
					_highLightActive = (CBool) CR2WTypeManager.Create("Bool", "highLightActive", cr2w, this);
				}
				return _highLightActive;
			}
			set
			{
				if (_highLightActive == value)
				{
					return;
				}
				_highLightActive = value;
				PropertySet(this);
			}
		}

		public BlindingLight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
