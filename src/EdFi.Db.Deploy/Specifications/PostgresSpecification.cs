﻿// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using EdFi.Db.Deploy.Parameters;

namespace EdFi.Db.Deploy.Specifications
{
    // ReSharper disable once UnusedMember.Global
    public class PostgresSpecification : CompositeOptionSpecification
    {
        public PostgresSpecification(IEnumerable<ISpecification<IOptions>> specifications)
            : base(specifications) { }

        protected override IEnumerable<ISpecification<IOptions>> FilteredSpecifications()
            => Specifications.Where(
                x => !x.GetType()
                    .Name.StartsWith("SqlServer", StringComparison.InvariantCultureIgnoreCase));
    }
}
