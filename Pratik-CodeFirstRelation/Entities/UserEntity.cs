﻿namespace Pratik_CodeFirstRelation.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<PostEntity> Posts { get; set; }
    }
}
