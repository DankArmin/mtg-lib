CREATE TABLE public.orders (
        id serial NOT NULL,
        email varchar NOT NULL,
        card_id bigint NOT NULL,
        created_at timestamp(0) without time zone,
        updated_at timestamp(0) without time zone
);

ALTER TABLE ONLY public.orders
        ADD CONSTRAINT orders_pkey PRIMARY KEY (id);