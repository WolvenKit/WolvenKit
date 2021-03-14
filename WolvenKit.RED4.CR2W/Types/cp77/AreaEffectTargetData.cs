using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AreaEffectTargetData : IScriptable
	{
		private CName _areaEffectID;
		private CBool _onSelf;
		private CBool _onSlaves;

		[Ordinal(0)] 
		[RED("areaEffectID")] 
		public CName AreaEffectID
		{
			get
			{
				if (_areaEffectID == null)
				{
					_areaEffectID = (CName) CR2WTypeManager.Create("CName", "areaEffectID", cr2w, this);
				}
				return _areaEffectID;
			}
			set
			{
				if (_areaEffectID == value)
				{
					return;
				}
				_areaEffectID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("onSelf")] 
		public CBool OnSelf
		{
			get
			{
				if (_onSelf == null)
				{
					_onSelf = (CBool) CR2WTypeManager.Create("Bool", "onSelf", cr2w, this);
				}
				return _onSelf;
			}
			set
			{
				if (_onSelf == value)
				{
					return;
				}
				_onSelf = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("onSlaves")] 
		public CBool OnSlaves
		{
			get
			{
				if (_onSlaves == null)
				{
					_onSlaves = (CBool) CR2WTypeManager.Create("Bool", "onSlaves", cr2w, this);
				}
				return _onSlaves;
			}
			set
			{
				if (_onSlaves == value)
				{
					return;
				}
				_onSlaves = value;
				PropertySet(this);
			}
		}

		public AreaEffectTargetData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
