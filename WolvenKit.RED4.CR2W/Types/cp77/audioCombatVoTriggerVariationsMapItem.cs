using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioCombatVoTriggerVariationsMapItem : CVariable
	{
		private CName _name;
		private CInt32 _numberOfVariations;
		private CBool _shuffle;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("numberOfVariations")] 
		public CInt32 NumberOfVariations
		{
			get
			{
				if (_numberOfVariations == null)
				{
					_numberOfVariations = (CInt32) CR2WTypeManager.Create("Int32", "numberOfVariations", cr2w, this);
				}
				return _numberOfVariations;
			}
			set
			{
				if (_numberOfVariations == value)
				{
					return;
				}
				_numberOfVariations = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("shuffle")] 
		public CBool Shuffle
		{
			get
			{
				if (_shuffle == null)
				{
					_shuffle = (CBool) CR2WTypeManager.Create("Bool", "shuffle", cr2w, this);
				}
				return _shuffle;
			}
			set
			{
				if (_shuffle == value)
				{
					return;
				}
				_shuffle = value;
				PropertySet(this);
			}
		}

		public audioCombatVoTriggerVariationsMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
