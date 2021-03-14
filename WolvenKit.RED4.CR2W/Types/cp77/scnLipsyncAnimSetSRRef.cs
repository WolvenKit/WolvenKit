using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnLipsyncAnimSetSRRef : CVariable
	{
		private rRef<animAnimSet> _lipsyncAnimSet;
		private raRef<animAnimSet> _asyncRefLipsyncAnimSet;

		[Ordinal(0)] 
		[RED("lipsyncAnimSet")] 
		public rRef<animAnimSet> LipsyncAnimSet
		{
			get
			{
				if (_lipsyncAnimSet == null)
				{
					_lipsyncAnimSet = (rRef<animAnimSet>) CR2WTypeManager.Create("rRef:animAnimSet", "lipsyncAnimSet", cr2w, this);
				}
				return _lipsyncAnimSet;
			}
			set
			{
				if (_lipsyncAnimSet == value)
				{
					return;
				}
				_lipsyncAnimSet = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("asyncRefLipsyncAnimSet")] 
		public raRef<animAnimSet> AsyncRefLipsyncAnimSet
		{
			get
			{
				if (_asyncRefLipsyncAnimSet == null)
				{
					_asyncRefLipsyncAnimSet = (raRef<animAnimSet>) CR2WTypeManager.Create("raRef:animAnimSet", "asyncRefLipsyncAnimSet", cr2w, this);
				}
				return _asyncRefLipsyncAnimSet;
			}
			set
			{
				if (_asyncRefLipsyncAnimSet == value)
				{
					return;
				}
				_asyncRefLipsyncAnimSet = value;
				PropertySet(this);
			}
		}

		public scnLipsyncAnimSetSRRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
