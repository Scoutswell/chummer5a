﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chummer
{
	public static class SkillExtensions
	{
		public static bool HasSpecialization(this Skill skill, string specialization)
		{
			return false;
		}

		public static string GetDisplayName(this Skill skill)
		{
			return skill.Name;
		}

		public static string GetDisplayAttribute(this Skill skill)
		{
			return skill.Attribute;
		}

		public static string GetDisplayCategory(this Skill skill)
		{
			return skill.SkillCategory;
		}

	}
}
