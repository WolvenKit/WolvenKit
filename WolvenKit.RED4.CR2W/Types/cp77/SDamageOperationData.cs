using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SDamageOperationData : CVariable
	{
		private CFloat _range;
		private Vector4 _offset;
		private TweakDBID _damageType;

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
		[RED("offset")] 
		public Vector4 Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (Vector4) CR2WTypeManager.Create("Vector4", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("damageType")] 
		public TweakDBID DamageType
		{
			get
			{
				if (_damageType == null)
				{
					_damageType = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "damageType", cr2w, this);
				}
				return _damageType;
			}
			set
			{
				if (_damageType == value)
				{
					return;
				}
				_damageType = value;
				PropertySet(this);
			}
		}

		public SDamageOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
