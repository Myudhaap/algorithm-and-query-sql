PGDMP  *                    |            db_bank_indonesia    16.1    16.1     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    39903    db_bank_indonesia    DATABASE     �   CREATE DATABASE db_bank_indonesia WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_Indonesia.1252';
 !   DROP DATABASE db_bank_indonesia;
                postgres    false            �            1259    39925    barang    TABLE     �   CREATE TABLE public.barang (
    kode character varying(255) NOT NULL,
    nama character varying(255),
    harga numeric(255,0)
);
    DROP TABLE public.barang;
       public         heap    postgres    false            �            1259    39918 	   pelanggan    TABLE     �   CREATE TABLE public.pelanggan (
    kode character varying(11) NOT NULL,
    nama character varying(255),
    alamat character varying(255)
);
    DROP TABLE public.pelanggan;
       public         heap    postgres    false            �            1259    39932 	   transaksi    TABLE     �   CREATE TABLE public.transaksi (
    kode character varying(255) NOT NULL,
    tanggal date,
    kode_pelanggan character varying(255),
    kode_barang character varying(255),
    jumlah_barang numeric(255,0)
);
    DROP TABLE public.transaksi;
       public         heap    postgres    false            �          0    39925    barang 
   TABLE DATA           3   COPY public.barang (kode, nama, harga) FROM stdin;
    public          postgres    false    216   q       �          0    39918 	   pelanggan 
   TABLE DATA           7   COPY public.pelanggan (kode, nama, alamat) FROM stdin;
    public          postgres    false    215   �       �          0    39932 	   transaksi 
   TABLE DATA           ^   COPY public.transaksi (kode, tanggal, kode_pelanggan, kode_barang, jumlah_barang) FROM stdin;
    public          postgres    false    217   �       $           2606    39931    barang barang_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.barang
    ADD CONSTRAINT barang_pkey PRIMARY KEY (kode);
 <   ALTER TABLE ONLY public.barang DROP CONSTRAINT barang_pkey;
       public            postgres    false    216            "           2606    39924    pelanggan pelanggan_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.pelanggan
    ADD CONSTRAINT pelanggan_pkey PRIMARY KEY (kode);
 B   ALTER TABLE ONLY public.pelanggan DROP CONSTRAINT pelanggan_pkey;
       public            postgres    false    215            &           2606    39938    transaksi transaksi_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.transaksi
    ADD CONSTRAINT transaksi_pkey PRIMARY KEY (kode);
 B   ALTER TABLE ONLY public.transaksi DROP CONSTRAINT transaksi_pkey;
       public            postgres    false    217            '           2606    39944 $   transaksi transaksi_kode_barang_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.transaksi
    ADD CONSTRAINT transaksi_kode_barang_fkey FOREIGN KEY (kode_barang) REFERENCES public.barang(kode);
 N   ALTER TABLE ONLY public.transaksi DROP CONSTRAINT transaksi_kode_barang_fkey;
       public          postgres    false    216    217    4644            (           2606    39939 '   transaksi transaksi_kode_pelanggan_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.transaksi
    ADD CONSTRAINT transaksi_kode_pelanggan_fkey FOREIGN KEY (kode_pelanggan) REFERENCES public.pelanggan(kode);
 Q   ALTER TABLE ONLY public.transaksi DROP CONSTRAINT transaksi_kode_pelanggan_fkey;
       public          postgres    false    4642    217    215            �   4   x�s2�tJ�*�44200�r2�tN�I�K�44 �9�SKJ9���=... 6>h      �   6   x�0��O���r�v
q�
0�t�K
89�����ss%f�&�b���� ��      �   d   x�U�K� �u���Gp�	�a����C�hu���L������~VPy�nq*���������Hx<� UU�Y[����I*yt@A$�d�v.Ƙ��'T     