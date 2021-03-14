using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldEditorForceAutoHideDistance : ISerializable
	{
		private CFloat _minAutoHideDistance;
		private CFloat _multiplier;

		[Ordinal(0)] 
		[RED("minAutoHideDistance")] 
		public CFloat MinAutoHideDistance
		{
			get
			{
				if (_minAutoHideDistance == null)
				{
					_minAutoHideDistance = (CFloat) CR2WTypeManager.Create("Float", "minAutoHideDistance", cr2w, this);
				}
				return _minAutoHideDistance;
			}
			set
			{
				if (_minAutoHideDistance == value)
				{
					return;
				}
				_minAutoHideDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("multiplier")] 
		public CFloat Multiplier
		{
			get
			{
				if (_multiplier == null)
				{
					_multiplier = (CFloat) CR2WTypeManager.Create("Float", "multiplier", cr2w, this);
				}
				return _multiplier;
			}
			set
			{
				if (_multiplier == value)
				{
					return;
				}
				_multiplier = value;
				PropertySet(this);
			}
		}

		public worldEditorForceAutoHideDistance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
