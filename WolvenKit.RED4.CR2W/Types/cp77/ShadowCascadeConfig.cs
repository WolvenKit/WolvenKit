using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShadowCascadeConfig : CVariable
	{
		private CFloat _range;
		private CFloat _filterSize;
		private CFloat _blendRange;
		private CFloat _biasOffset;

		[Ordinal(0)] 
		[RED("range")] 
		public CFloat Range
		{
			get
			{
				if (_range == null)
				{
					_range = (CFloat) CR2WTypeManager.Create("Float", "range", cr2w, this);
				}
				return _range;
			}
			set
			{
				if (_range == value)
				{
					return;
				}
				_range = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("filterSize")] 
		public CFloat FilterSize
		{
			get
			{
				if (_filterSize == null)
				{
					_filterSize = (CFloat) CR2WTypeManager.Create("Float", "filterSize", cr2w, this);
				}
				return _filterSize;
			}
			set
			{
				if (_filterSize == value)
				{
					return;
				}
				_filterSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("blendRange")] 
		public CFloat BlendRange
		{
			get
			{
				if (_blendRange == null)
				{
					_blendRange = (CFloat) CR2WTypeManager.Create("Float", "blendRange", cr2w, this);
				}
				return _blendRange;
			}
			set
			{
				if (_blendRange == value)
				{
					return;
				}
				_blendRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("biasOffset")] 
		public CFloat BiasOffset
		{
			get
			{
				if (_biasOffset == null)
				{
					_biasOffset = (CFloat) CR2WTypeManager.Create("Float", "biasOffset", cr2w, this);
				}
				return _biasOffset;
			}
			set
			{
				if (_biasOffset == value)
				{
					return;
				}
				_biasOffset = value;
				PropertySet(this);
			}
		}

		public ShadowCascadeConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
