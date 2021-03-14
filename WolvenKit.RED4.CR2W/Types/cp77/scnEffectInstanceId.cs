using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnEffectInstanceId : CVariable
	{
		private scnEffectId _effectId;
		private CUInt32 _id;

		[Ordinal(0)] 
		[RED("effectId")] 
		public scnEffectId EffectId
		{
			get
			{
				if (_effectId == null)
				{
					_effectId = (scnEffectId) CR2WTypeManager.Create("scnEffectId", "effectId", cr2w, this);
				}
				return _effectId;
			}
			set
			{
				if (_effectId == value)
				{
					return;
				}
				_effectId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CUInt32) CR2WTypeManager.Create("Uint32", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		public scnEffectInstanceId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
