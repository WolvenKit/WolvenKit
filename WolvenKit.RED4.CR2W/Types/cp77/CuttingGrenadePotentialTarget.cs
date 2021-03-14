using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CuttingGrenadePotentialTarget : CVariable
	{
		private wCHandle<ScriptedPuppet> _entity;
		private CInt32 _hits;

		[Ordinal(0)] 
		[RED("entity")] 
		public wCHandle<ScriptedPuppet> Entity
		{
			get
			{
				if (_entity == null)
				{
					_entity = (wCHandle<ScriptedPuppet>) CR2WTypeManager.Create("whandle:ScriptedPuppet", "entity", cr2w, this);
				}
				return _entity;
			}
			set
			{
				if (_entity == value)
				{
					return;
				}
				_entity = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hits")] 
		public CInt32 Hits
		{
			get
			{
				if (_hits == null)
				{
					_hits = (CInt32) CR2WTypeManager.Create("Int32", "hits", cr2w, this);
				}
				return _hits;
			}
			set
			{
				if (_hits == value)
				{
					return;
				}
				_hits = value;
				PropertySet(this);
			}
		}

		public CuttingGrenadePotentialTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
