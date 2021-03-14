using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendTextureRegionPart : ISerializable
	{
		private Vector4 _innerRegion;
		private Vector4 _outerRegion;

		[Ordinal(0)] 
		[RED("innerRegion")] 
		public Vector4 InnerRegion
		{
			get
			{
				if (_innerRegion == null)
				{
					_innerRegion = (Vector4) CR2WTypeManager.Create("Vector4", "innerRegion", cr2w, this);
				}
				return _innerRegion;
			}
			set
			{
				if (_innerRegion == value)
				{
					return;
				}
				_innerRegion = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("outerRegion")] 
		public Vector4 OuterRegion
		{
			get
			{
				if (_outerRegion == null)
				{
					_outerRegion = (Vector4) CR2WTypeManager.Create("Vector4", "outerRegion", cr2w, this);
				}
				return _outerRegion;
			}
			set
			{
				if (_outerRegion == value)
				{
					return;
				}
				_outerRegion = value;
				PropertySet(this);
			}
		}

		public rendTextureRegionPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
