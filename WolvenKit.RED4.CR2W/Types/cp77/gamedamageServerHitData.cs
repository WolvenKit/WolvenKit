using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedamageServerHitData : IScriptable
	{
		private CUInt32 _id;
		private CArray<gameuiDamageInfo> _damageInfos;
		private wCHandle<gameObject> _instigator;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("damageInfos")] 
		public CArray<gameuiDamageInfo> DamageInfos
		{
			get
			{
				if (_damageInfos == null)
				{
					_damageInfos = (CArray<gameuiDamageInfo>) CR2WTypeManager.Create("array:gameuiDamageInfo", "damageInfos", cr2w, this);
				}
				return _damageInfos;
			}
			set
			{
				if (_damageInfos == value)
				{
					return;
				}
				_damageInfos = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("instigator")] 
		public wCHandle<gameObject> Instigator
		{
			get
			{
				if (_instigator == null)
				{
					_instigator = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "instigator", cr2w, this);
				}
				return _instigator;
			}
			set
			{
				if (_instigator == value)
				{
					return;
				}
				_instigator = value;
				PropertySet(this);
			}
		}

		public gamedamageServerHitData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
