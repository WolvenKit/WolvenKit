using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_PreClimbing : animAnimFeature
	{
		private Vector4 _edgePositionLS;
		private CFloat _valid;

		[Ordinal(0)] 
		[RED("edgePositionLS")] 
		public Vector4 EdgePositionLS
		{
			get
			{
				if (_edgePositionLS == null)
				{
					_edgePositionLS = (Vector4) CR2WTypeManager.Create("Vector4", "edgePositionLS", cr2w, this);
				}
				return _edgePositionLS;
			}
			set
			{
				if (_edgePositionLS == value)
				{
					return;
				}
				_edgePositionLS = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("valid")] 
		public CFloat Valid
		{
			get
			{
				if (_valid == null)
				{
					_valid = (CFloat) CR2WTypeManager.Create("Float", "valid", cr2w, this);
				}
				return _valid;
			}
			set
			{
				if (_valid == value)
				{
					return;
				}
				_valid = value;
				PropertySet(this);
			}
		}

		public AnimFeature_PreClimbing(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
