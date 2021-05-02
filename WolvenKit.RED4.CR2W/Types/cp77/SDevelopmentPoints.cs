using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SDevelopmentPoints : CVariable
	{
		private CEnum<gamedataDevelopmentPointType> _type;
		private CInt32 _spent;
		private CInt32 _unspent;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataDevelopmentPointType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("spent")] 
		public CInt32 Spent
		{
			get => GetProperty(ref _spent);
			set => SetProperty(ref _spent, value);
		}

		[Ordinal(2)] 
		[RED("unspent")] 
		public CInt32 Unspent
		{
			get => GetProperty(ref _unspent);
			set => SetProperty(ref _unspent, value);
		}

		public SDevelopmentPoints(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
