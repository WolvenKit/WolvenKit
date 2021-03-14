using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldFoliageBrushParams : CVariable
	{
		private CFloat _proximity;
		private CFloat _scale;
		private CFloat _scaleVariation;

		[Ordinal(0)] 
		[RED("Proximity")] 
		public CFloat Proximity
		{
			get
			{
				if (_proximity == null)
				{
					_proximity = (CFloat) CR2WTypeManager.Create("Float", "Proximity", cr2w, this);
				}
				return _proximity;
			}
			set
			{
				if (_proximity == value)
				{
					return;
				}
				_proximity = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("Scale")] 
		public CFloat Scale
		{
			get
			{
				if (_scale == null)
				{
					_scale = (CFloat) CR2WTypeManager.Create("Float", "Scale", cr2w, this);
				}
				return _scale;
			}
			set
			{
				if (_scale == value)
				{
					return;
				}
				_scale = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ScaleVariation")] 
		public CFloat ScaleVariation
		{
			get
			{
				if (_scaleVariation == null)
				{
					_scaleVariation = (CFloat) CR2WTypeManager.Create("Float", "ScaleVariation", cr2w, this);
				}
				return _scaleVariation;
			}
			set
			{
				if (_scaleVariation == value)
				{
					return;
				}
				_scaleVariation = value;
				PropertySet(this);
			}
		}

		public worldFoliageBrushParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
