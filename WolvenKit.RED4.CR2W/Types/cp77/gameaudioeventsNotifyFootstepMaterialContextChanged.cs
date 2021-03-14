using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsNotifyFootstepMaterialContextChanged : redEvent
	{
		private CName _footwareType;
		private CName _surfaceFlavourName;

		[Ordinal(0)] 
		[RED("footwareType")] 
		public CName FootwareType
		{
			get
			{
				if (_footwareType == null)
				{
					_footwareType = (CName) CR2WTypeManager.Create("CName", "footwareType", cr2w, this);
				}
				return _footwareType;
			}
			set
			{
				if (_footwareType == value)
				{
					return;
				}
				_footwareType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("surfaceFlavourName")] 
		public CName SurfaceFlavourName
		{
			get
			{
				if (_surfaceFlavourName == null)
				{
					_surfaceFlavourName = (CName) CR2WTypeManager.Create("CName", "surfaceFlavourName", cr2w, this);
				}
				return _surfaceFlavourName;
			}
			set
			{
				if (_surfaceFlavourName == value)
				{
					return;
				}
				_surfaceFlavourName = value;
				PropertySet(this);
			}
		}

		public gameaudioeventsNotifyFootstepMaterialContextChanged(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
