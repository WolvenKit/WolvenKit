using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrossingLightSetup : CVariable
	{
		private CName _greenLightSFX;
		private CName _redLightSFX;

		[Ordinal(0)] 
		[RED("greenLightSFX")] 
		public CName GreenLightSFX
		{
			get
			{
				if (_greenLightSFX == null)
				{
					_greenLightSFX = (CName) CR2WTypeManager.Create("CName", "greenLightSFX", cr2w, this);
				}
				return _greenLightSFX;
			}
			set
			{
				if (_greenLightSFX == value)
				{
					return;
				}
				_greenLightSFX = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("redLightSFX")] 
		public CName RedLightSFX
		{
			get
			{
				if (_redLightSFX == null)
				{
					_redLightSFX = (CName) CR2WTypeManager.Create("CName", "redLightSFX", cr2w, this);
				}
				return _redLightSFX;
			}
			set
			{
				if (_redLightSFX == value)
				{
					return;
				}
				_redLightSFX = value;
				PropertySet(this);
			}
		}

		public CrossingLightSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
